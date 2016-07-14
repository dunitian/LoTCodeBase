using System.Configuration;
using System.Net.Mail;
using System.Threading.Tasks;

public class MailModel
{
    /// <summary>
    /// 邮箱主题
    /// </summary>
    public string MailSubject { get; set; }
    /// <summary>
    /// 邮箱内容
    /// </summary>
    public string MailContent { get; set; }
    /// <summary>
    /// 收件人邮箱
    /// </summary>
    public string[] MailTo { get; set; }
    /// <summary>
    /// 抄送人邮箱
    /// </summary>
    public string[] MailCC { get; set; }
    /// <summary>
    /// 附件路径
    /// </summary>
    public string[] AttachmentsPath { get; set; }
}

public class EmailHelper
{
    private static string mailFrom = ConfigurationManager.AppSettings["EmailForm"]; //登陆用户名
    private static string mailPass = ConfigurationManager.AppSettings["EmailPass"]; //登陆密码
    private static string mailSmtp = ConfigurationManager.AppSettings["EmailSmtp"]; //SMTP服务器

    /// <summary>
    /// 发送邮件
    /// </summary>
    /// <param name="mailSubject">邮箱主题</param>
    /// <param name="mailContent">邮箱内容</param>
    /// <param name="mailTo">收件人邮箱</param>
    /// <param name="mailCC">抄送人邮箱</param>
    /// <param name="attachmentsPath">附件路径</param>
    /// <returns>返回发送邮箱的结果</returns>
    public static async Task<bool> SendAsync(MailModel model)
    {
        //基本校验（如不需要可删除）
        if (model == null || string.IsNullOrWhiteSpace(model.MailSubject) || string.IsNullOrWhiteSpace(model.MailContent) || model.MailTo == null)
        {
            return false;
        }

        //邮件服务设置
        using (var smtpClient = new SmtpClient())
        {
            smtpClient.Host = mailSmtp;                                                     //指定SMTP服务器
            smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, mailPass);  //用户名和密码

            using (var mailMsg = new MailMessage())
            {
                //发信人邮箱
                mailMsg.From = new MailAddress(mailFrom);
                //收件人邮箱
                for (int i = 0; i < model.MailTo.Length; i++)
                {
                    mailMsg.To.Add(model.MailTo[i]);
                }
                //抄送人邮箱
                if (model.MailCC != null)
                {
                    for (int i = 0; i < model.MailCC.Length; i++)
                    {
                        mailMsg.CC.Add(model.MailCC[i]);
                    }
                }
                //附件系列
                if (model.AttachmentsPath != null)
                {

                    for (int i = 0; i < model.AttachmentsPath.Length; i++)
                    {
                        try
                        {
                            mailMsg.Attachments.Add(new Attachment(model.AttachmentsPath[i]));
                        }
                        catch (System.Exception ex)
                        {
                            continue;
                        }
                    }

                }
                mailMsg.Subject = model.MailSubject;                //主题
                mailMsg.Body = model.MailContent;                   //内容
                mailMsg.BodyEncoding = System.Text.Encoding.UTF8;   //编码
                mailMsg.IsBodyHtml = true;                          //HTML格式
                try
                {
                    await smtpClient.SendMailAsync(mailMsg); //发送邮件
                    return true;
                }
                catch (System.Exception ex)
                {
                    mailMsg.Dispose();
                    smtpClient.Dispose();
                    return false;
                }
            }
        }
    }
}