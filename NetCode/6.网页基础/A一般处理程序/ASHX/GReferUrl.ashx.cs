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
            if (Common.DomainHelper.IsOtherDomain(context)) { context.Response.End(); }
            context.Response.Write("<img src='/Images/dnt.jpg'/>");
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