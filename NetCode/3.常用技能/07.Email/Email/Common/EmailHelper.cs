using System.Net.Mail;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

public class EmailHelper
{
    public static string mailFrom = ConfigurationManager.AppSettings["EmailForm"]; //登陆用户名
    public static string mailPass = ConfigurationManager.AppSettings["EmailPass"]; //登陆密码
    public static string mailSmtp = ConfigurationManager.AppSettings["EmailSmtp"]; //SMTP服务器

    /// <summary>
    /// 发送邮件
    /// </summary>
    /// <param name="mailTo">要发送的邮箱</param>
    /// <param name="mailSubject">邮箱主题</param>
    /// <param name="mailContent">邮箱内容</param>
    /// <returns>返回发送邮箱的结果</returns>
    public static async Task<bool> SendAsync(string mailTo, string mailSubject, string mailContent)
    {
        // 邮件服务设置
        using (var smtpClient = new SmtpClient())
        {
            smtpClient.Host = mailSmtp;                                                     //指定SMTP服务器
            smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, mailPass);  //用户名和密码

            using (var mailMessage = new MailMessage(mailFrom, mailTo)) //发送人和收件人
            {
                mailMessage.Subject = mailSubject;                      //主题
                mailMessage.Body = mailContent;                         //内容
                mailMessage.BodyEncoding = Encoding.UTF8;               //编码
                mailMessage.IsBodyHtml = true;                          //HTML格式
                try
                {
                    await smtpClient.SendMailAsync(mailMessage); // 发送邮件
                    return true;
                }
                catch (System.Exception ex)
                {
                    mailMessage.Dispose();
                    smtpClient.Dispose();
                    return false;
                }
            }
        }
    }
}