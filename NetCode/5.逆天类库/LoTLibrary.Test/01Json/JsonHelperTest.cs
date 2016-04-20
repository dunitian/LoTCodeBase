using System;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LoTLibrary.Test
{
    [TestClass]
    public class JsonHelperTest
    {
        [TestMethod]
        public string ObjectToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
