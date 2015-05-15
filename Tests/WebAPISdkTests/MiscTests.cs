using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OrionApiSdk.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using OrionApiSdk.Code;
namespace OrionApiSdk.Tests

{
    [TestClass()]
    public class MiscTests : TestBase
    {
        [TestMethod()]
        public void ListEndpoints()
        {
            Authenticate();
            var target = OrionApi.ApiBase.GetJson("Security/Endpoints");
            var actual = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(target);
            Assert.IsTrue(actual is string[]);
           int num = ((string[])actual).Count();
           Assert.IsTrue(num > 0);
        }
    }
}
