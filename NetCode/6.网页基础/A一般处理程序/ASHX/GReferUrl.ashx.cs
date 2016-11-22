using System.Web;

namespace CSharpStudy
{
    /// <summary>
    /// 07.防盗链或网络营销
    /// </summary>
    public class GReferUrl : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "image/jpeg";

            if (Common.DomainHelper.IsOtherDomain(context))
                context.Response.WriteFile(context.Request.MapPath("/Images/gogogo.jpg"));
            else
                context.Response.WriteFile(context.Request.MapPath("/Images/dnt.jpg"));
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}