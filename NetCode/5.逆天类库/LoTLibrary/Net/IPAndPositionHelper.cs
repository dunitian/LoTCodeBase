using System;
using System.IO;
using System.Text;

public class IPAndPositionHelper
{
    #region Resource
    public static bool EnableFileWatch = false;

    private static int offset;
    private static uint[] index = new uint[256];
    private static byte[] dataBuffer;
    private static byte[] indexBuffer;
    private static long lastModifyTime = 0L;
    private static string ipFile;
    private static readonly object @lock = new object();
    #endregion

    #region LoadDat
    public static void Load(string filename)
    {
        ipFile = new FileInfo(filename).FullName;
        Load();
        if (EnableFileWatch)
        {
            Watch();
        }
    }

    private static void Load()
    {
        lock (@lock)
        {
            var file = new FileInfo(ipFile);
            lastModifyTime = file.LastWriteTime.Ticks;
            try
            {
                dataBuffer = new byte[file.Length];
                using (var fin = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
                {
                    fin.Read(dataBuffer, 0, dataBuffer.Length);
                }

                var indexLength = BytesToLong(dataBuffer[0], dataBuffer[1], dataBuffer[2], dataBuffer[3]);
                indexBuffer = new byte[indexLength];
                Array.Copy(dataBuffer, 4, indexBuffer, 0, indexLength);
                offset = (int)indexLength;

                for (var loop = 0; loop < 256; loop++)
                {
                    index[loop] = BytesToLong(indexBuffer[loop * 4 + 3], indexBuffer[loop * 4 + 2],
                        indexBuffer[loop * 4 + 1],
                        indexBuffer[loop * 4]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    private static uint BytesToLong(byte a, byte b, byte c, byte d)
    {
        return ((uint)a << 24) | ((uint)b << 16) | ((uint)c << 8) | d;
    }

    private static void Watch()
    {
        var file = new FileInfo(ipFile);
        if (file.DirectoryName == null) return;
        var watcher = new FileSystemWatcher(file.DirectoryName, file.Name) { NotifyFilter = NotifyFilters.LastWrite };
        watcher.Changed += (s, e) =>
        {
            var time = File.GetLastWriteTime(ipFile).Ticks;
            if (time > lastModifyTime)
            {
                Load();
            }
        };
        watcher.EnableRaisingEvents = true;
    }
    #endregion

    #region FindIP
    public static string[] Find(string ip)
    {
        lock (@lock)
        {
            var ips = ip.Split('.');
            var ip_prefix_value = int.Parse(ips[0]);
            long ip2long_value = BytesToLong(byte.Parse(ips[0]), byte.Parse(ips[1]), byte.Parse(ips[2]),
                byte.Parse(ips[3]));
            var start = index[ip_prefix_value];
            var max_comp_len = offset - 1028;
            long index_offset = -1;
            var index_length = -1;
            byte b = 0;
            for (start = start * 8 + 1024; start < max_comp_len; start += 8)
            {
                if (
                    BytesToLong(indexBuffer[start + 0], indexBuffer[start + 1], indexBuffer[start + 2],
                        indexBuffer[start + 3]) >= ip2long_value)
                {
                    index_offset = BytesToLong(b, indexBuffer[start + 6], indexBuffer[start + 5],
                        indexBuffer[start + 4]);
                    index_length = 0xFF & indexBuffer[start + 7];
                    break;
                }
            }
            var areaBytes = new byte[index_length];
            Array.Copy(dataBuffer, offset + (int)index_offset - 1024, areaBytes, 0, index_length);
            return Encoding.UTF8.GetString(areaBytes).Split('\t');
        }
    }
    #endregion
}
