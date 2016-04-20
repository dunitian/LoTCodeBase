using System;
using System.Collections.Generic;

namespace _01.Json系列
{
    class Program
    {
        static void Main(string[] args)
        {
            //把Json转换为指定T
            Console.WriteLine("把Json转换为指定T\n");
            string jsonStr = "[{\"MName\": \"白鲫鱼\",\"MPrice\": \"9.99\",\"MType\": \"大荤\",\"CPName\": null,\"CName\": null,\"SName\": \"茂业\"},{\"MName\": \"肥肉馅\",\"MPrice\": \"10.99\",\"MType\": \"大荤\",\"CPName\": null,\"CName\": null,\"SName\": \"茂业\"},{\"MName\": \"洋鸡蛋\",\"MPrice\": \"3.79\",\"MType\": \"小荤\",\"CPName\": null,\"CName\": null,\"SName\": \"茂业\"}]";
            var shopMenuList = jsonStr.JsonToModels<IEnumerable<ShopMenu>>();
            if (shopMenuList != null)
                foreach (var item in shopMenuList)
                {
                    Console.WriteLine(item.MName + " " + item.MPrice + " " + item.MType + " " + item.SName);
                }

            //把指定类型转换为Json
            Console.WriteLine("\n\n把指定类型转换为Json\n");
            IEnumerable<ShopMenu> list = new List<ShopMenu>() {
                new ShopMenu {MName= "白鲫鱼",MPrice= "9.99",MType= "大荤", SName= "茂业"},
                new ShopMenu {MName= "肥肉馅",MPrice= "10.99",MType= "大荤", SName= "茂业"},
                new ShopMenu {MName= "洋鸡蛋",MPrice= "3.79",MType= "小荤", SName= "茂业"}
              };
            Console.WriteLine(list.ObjectToJson());
            Console.WriteLine();

            string[] strs = { "1", "2", "3" };
            Console.WriteLine(strs.ObjectToJson());
            Console.WriteLine();

            string tempStr = "我去";
            Console.WriteLine(tempStr.ObjectToJson());
            Console.ReadKey();
        }


    }
}
