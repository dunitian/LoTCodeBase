using System.Net;
using System.Threading.Tasks;

namespace _1._1.DNS
{
    public abstract partial class NetHelper
    {
        /// <summary>
        /// 获取PC名
        /// </summary>
        /// <returns></returns>
        public static string GetPCName()
        {
            return Dns.GetHostName();
        }

        /// <summary>
        /// 获取DNS信息
        /// </summary>
        /// <param name="address">IP地址或者Host Name</param>
        /// <returns></returns>
        //public static string GetDNSInfo(string address)
        public async static Task<string> GetDNSInfo(string address)
        {
            //return Dns.GetHostEntryAsync(address).Result.HostName;
            var host = await Dns.GetHostEntryAsync(address);
            return host.HostName;
        }

        /// <summary>
        /// 获取IP地址数组
        /// </summary>
        /// <param name="urlStr"></param>
        /// <returns></returns>
        public async static Task<IPAddress[]> GetHostAddresses(string urlStr)
        {
            if (urlStr.Contains("http"))
            {
                urlStr = urlStr.Replace("http://", "").Replace("https://", "");
            }
            return await Dns.GetHostAddressesAsync(urlStr);
        }
    }
}
