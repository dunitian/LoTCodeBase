using System.IO;

public static class FileHelper
{
    /*文件扩展名说明 仅参考
        *4946/104116 txt
        *7173        gif 
        *255216      jpg
        *13780       png
        *6677        bmp
        *239187      aspx,asp,sql
        *208207      xls.doc.ppt
        *6063        xml
        *6033        htm,html
        *4742        js
        *8075        xlsx,zip,pptx,mmap,zip
        *8297        rar   
        *01          accdb,mdb
        *7790        exe,dll           
        *5666        psd 
        *255254      rdp 
        *10056       bt种子 
        *64101       bat 
        *4059        sgf
   */
    /// <summary>
    /// 判断扩展名是否是指定类型---默认是判断图片格式，符合返回true
    /// eg：file,"7173", "255216", "6677", "13780" //gif  //jpg  //bmp //png
    /// </summary>
    /// <param name="stream">文件流</param>
    /// <param name="fileTypes">文件扩展名</param>
    /// <returns></returns>
    public static bool CheckingExt(this Stream stream, params string[] fileTypes)
    {
        if (fileTypes.Length == 0) { fileTypes = new string[] { "7173", "255216", "6677", "13780" }; }
        bool result = false;
        string fileclass = "";

        #region 读取头两个字节
        using (stream)
        {
            using (var reader = new BinaryReader(stream))
            {
                try
                {
                    //读取每个文件的头两个字节
                    for (int i = 0; i < 2; i++)
                    {
                        byte buffer = reader.ReadByte();
                        fileclass += buffer.ToString();
                    }
                }
                catch { return false; }
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
