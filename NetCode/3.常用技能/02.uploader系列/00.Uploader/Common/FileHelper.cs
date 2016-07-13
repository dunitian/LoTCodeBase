using System.IO;

public static class FileHelper
{
    /*头文件参考：（我自己测是如有偏差请联系我）
        7790：exe，dll

        5666：psd
        6677：bmp
        7173：gif
        13780：png
        255216：jpg,jpeg
        

        8297：rar
        55122：7z
        8075：docx，xlsx，pptx，vsdx，mmap，xmind，“zip”
        208207：doc，xls，ppt，mpp，vsd
   */
    /// <summary>
    /// 判断扩展名是否是指定类型---默认是判断图片格式，符合返回true
    /// eg：图片+压缩+文档："7173", "255216", "6677", "13780", "8297", "55122", "8075", "208207"
    /// eg：img，"7173", "255216", "6677", "13780" //gif  //jpg  //bmp //png
    /// eg：file,"8297", "55122", "8075", "208207" //rar //7z //zip + 文档系列
    /// </summary>
    /// <param name="stream">文件流</param>
    /// <param name="fileTypes">文件扩展名</param>
    /// <returns></returns>
    public static bool CheckingExt(this Stream stream, params string[] fileTypes)
    {
        if (fileTypes == null || fileTypes.Length == 0) { fileTypes = new string[] { "7173", "255216", "6677", "13780" }; }
        bool result = false;
        string fileclass = "";

        #region 读取头两个字节
        using (stream)
        {
            using (var reader = new BinaryReader(stream))
            {
                byte[] buff = new byte[2];
                try
                {
                    //读取每个文件的头两个字节
                    reader.Read(buff, 0, 2);
                    fileclass = buff[0].ToString() + buff[1].ToString();
                }
                catch (System.Exception ex) { return false; }
            }
        }
        #endregion

        #region 校验
        for (int i = 0; i < fileTypes.Length; i++)
        {
            if (fileclass == fileTypes[i])
            {
                result = true;
                break;
            }
        }
        #endregion
        return result;
    }
}