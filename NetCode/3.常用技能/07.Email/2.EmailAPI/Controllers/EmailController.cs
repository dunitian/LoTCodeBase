using System.Threading.Tasks;
using System.Web.Http;

namespace _2.EmailAPI.Models.Controllers
{
    public class EmailController : ApiController
    {
        #region 发邮件
        /// <summary>
        /// 发邮件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [CrossSite]
        public async Task<string> Post([FromUri]MailModel model)
        {
            var obj = new AjaxOption<object>();

            #region 校验系列
            if (model == null)
            {
                obj.Msg = "内容不能为空";
            }

            if (string.IsNullOrWhiteSpace(model.MailSubject))
            {
                obj.Msg = "邮件主题不能为空";
            }

            if (string.IsNullOrWhiteSpace(model.MailContent))
            {
                obj.Msg = "邮件内容不能为空";
            }

            #region 收件人邮箱
            if (model.MailToList != null)
            {
                foreach (var item in model.MailToList)
                {
                    if (!item.IsEmail())
                    {
                        model.MailToList.Remove(item);
                    }
                }
            }
            else
            {
                obj.Msg = "收件人邮箱不能为空";
            }

            //这个一定要加
            if (model.MailToList.Count == 0)
            {
                obj.Msg = "收件人邮箱不能为空";
            }
            #endregion

            if (model.MailCCList.ExistsData())
            {
                foreach (var item in model.MailCCList)
                {
                    if (!item.IsEmail())
                    {
                        model.MailCCList.Remove(item);
                    }
                }
            }
            #endregion

            //内容解码
            model.MailContent = System.Web.HttpUtility.UrlDecode(model.MailContent);

            if (obj.Msg.IsNullOrWhiteSpace())
                obj.Status = await EmailHelper.SendAsync(model);

            return obj.ObjectToJson();
        }
        #endregion
    }
}
