using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OrionApiSdk.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace OrionApiSdk.Tests
{
    [TestClass()]
    public class PortfolioTests : TestBase
    {
        [TestMethod()]
        public void AccountsSearchTest()
        {
            Authenticate();

            var accts = GetConfigValue(this.GetType().Name, System.Reflection.MethodInfo
                .GetCurrentMethod().Name, "Filter");
            
            var expected = 1;

            try
            {
                var actual = OrionApi.Portfolio.AccountsSearch(accts.ToString());
                Assert.AreEqual(expected, actual.Count);
                Assert.IsNotNull(actual[0].name);
                Assert.IsNotNull(actual[0].clientId);
                Assert.IsNotNull(actual[0].custodian);
                Assert.IsNotNull(actual[0].id);
                Assert.IsNotNull(actual[0].isActive);
                Assert.IsNotNull(actual[0].managementStyle);
                Assert.IsNotNull(actual[0].number);

            }
            catch (Exception ex)
            {
                HandleError(System.Reflection.MethodInfo.GetCurrentMethod().Name, ex);
                Assert.Fail();
            }
                
        }

        [TestMethod]
        public void AccountsTest()
        {
            Authenticate();

            var from = DateTime.Parse("07/15/2014");
            var actual = OrionApi.Portfolio.Accounts(createdDateStart: from, isActive: true);
            Assert.IsTrue(actual.Count > 0);

        }
    }
}
