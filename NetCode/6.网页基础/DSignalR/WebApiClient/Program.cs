using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建 HttpCient 并且去获取 api/values 
            HttpClient client = new HttpClient();

            var response = client.GetAsync("http://localhost:3845/api/SignalR").Result;

            Console.WriteLine(response);
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            Console.ReadKey();
        }
    }
}
