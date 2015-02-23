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
        public void ClientsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientsSimpleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientsValueTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientsSearchTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientsSearchValueTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientVerboseNewTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientVerboseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ClientSaveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RegistrationsSimpleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RegistrationVerboseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RegistrationVerboseNewTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RegistrationSaveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RegistrationsSearchTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RegistrationsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RegistrationsForClientTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RepresentativesSimpleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccountsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccountsSimpleTest()
        {
        }

        [TestMethod()]
        public void AccountsValueTest()
        {
            Assert.Fail();
        }

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

        [TestMethod()]
        public void AccountsValueSearchTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccountsVerboseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccountVerboseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccountVerboseNewTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccountSaveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccountStatusesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccountTypesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BrokerDealersSimpleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CustodiansSimpleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FundFamiliesSimpleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RepresentativesSimpleTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PlatformsSimpleTest()
        {
            Assert.Fail();
        }

    }
}
