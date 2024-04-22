using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Newtonsoft.Json.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            string src = "[012]";
            object v = JsonConvert.DeserializeObject<List<object>>(src);
            Console.WriteLine(v);
        }
    }
}
