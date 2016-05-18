using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OWIN.WebAPi_SignalR.Controller
{
    public class SignalRController : ApiController
    {
        public string Get()
        {
            return "get";
        }

        /// <summary>
        /// 方法可以重载
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(string id)
        {
            return "get：" + id;
        }

        public string Post()
        {
            return "post";
        }

        public string Put()
        {
            return "Put";
        }

        public string Delete()
        {
            return "delete";
        }
    }
}
