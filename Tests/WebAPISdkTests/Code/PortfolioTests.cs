using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OrionApiSdk.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace OrionApiSdk.Code.Tests
{
    [TestClass()]
    public class PortfolioTests
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
            var env = (OrionEnvironment)Enum.Parse(typeof(OrionEnvironment), "Test");
            var secret = GetAuth();
            var uid = secret.Key;
            var pass = secret.Value;

            var accts = GetConfigValue(System.Reflection.MethodInfo
                .GetCurrentMethod().Name, "Filter");
            var expected = 1;

            OrionApi.Authenticate(uid, pass, env);
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
                dynamic apiResult = Newtonsoft.Json.JsonConvert.DeserializeObject(ex.Message);
                var msg = String.Format("ApiResult: {0}. Error: {1}, Details: {2}, Trace:{3}",
                    apiResult.UserException.Detail.ToString(), ex.Message, ex.InnerException, ex.StackTrace);
                var file = 
                    String.Format(@"C:\Temp\OrionApiSdk.Code.Tests.PortfolioTests.{0}_Errors{1}.mstest"
                    , System.Reflection.MethodInfo.GetCurrentMethod().Name
                    , DateTime.Now.ToString("mmDDYYhhmmsss"));
                System.IO.File.WriteAllText(file, msg);
                Assert.Fail(apiResult.UserException.Detail.ToString());
            }
                
        }

        [TestMethod()]
        public void AccountsSearch_Permissions_Are_Inadequate()
        {
            var env = (OrionEnvironment)Enum.Parse(typeof(OrionEnvironment), "Test");

            var secret = GetAuth();
            var uid = secret.Key;
            var pass = secret.Value;

            var accts = GetConfigValue(System.Reflection.MethodInfo
                .GetCurrentMethod().Name, "Filter");

            var expected = 1;
            dynamic apiResult = null;

            try
            {
                OrionApi.Authenticate(uid, pass, env);
                var actual = OrionApi.Portfolio.AccountsSearch(accts);
            }
            catch (Exception ex)
            {
               apiResult = Newtonsoft.Json.JsonConvert.DeserializeObject(ex.Message);
            }
            Assert.IsTrue(apiResult.UserException.Detail.ToString() == "The process does not possess some privilege required for this operation.");
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

        /// <summary>
        /// Use this method to generate a auth template for the REST API
        /// activate the template by removing the .example file extension
        /// This template should contain your username and password for the API
        /// and should not be in source control.
        /// </summary>
        [TestMethod]
        public void Utility_GenerateAuth()
        {
            dynamic d = new ExpandoObject();
            d.Auth = new ExpandoObject();
            d.Auth.UserName = "USERNAME";
            d.Auth.Password = "PASSWORD";
            string payload = Newtonsoft.Json.JsonConvert.SerializeObject(d);
            System.IO.File.WriteAllText(@"C:\temp\Auth.json.example", payload);
        }

        /// <summary>
        /// Use this method to generate a configuration template for the test class
        /// activate the template by removing the .example file extension
        /// This template should contain all variables specific to your installation of
        /// Orion, and should not of course be in source control
        /// </summary>
        [TestMethod]
        public void Utility_GenerateTestConfig()
        {

            var classConfig = new List<ExpandoObject>();
            var configItem = new ExpandoObject(); //methodName, configKey, configValue

            dynamic a = new ExpandoObject();
            a.MethodName = "TestMethod1";
            a.Key = "Parameter1";
            a.Value = "Parameter1Value";
            dynamic b = new ExpandoObject();
            b.MethodName = "TestMethod1";
            b.Key = "Parameter2";
            b.Value = "Parameter2Value";
            dynamic c = new ExpandoObject();
            c.MethodName = "TestMethod1";
            c.Key = "Parameter3";
            c.Value = "Parameter3Value";

            dynamic d = new ExpandoObject();
            d.MethodName = "TestMethod2";
            d.Key = "Parameter1";
            d.Value = "Parameter1Value";
            dynamic e = new ExpandoObject();
            e.MethodName = "TestMethod2";
            e.Key = "Parameter2";
            e.Value = "Parameter2Value";
            dynamic f = new ExpandoObject();
            f.MethodName = "TestMethod2";
            f.Key = "Parameter3";
            f.Value = "Parameter3Value";

            dynamic g = new ExpandoObject();
            g.MethodName = "TestMethod3";
            g.Key = "Parameter1";
            g.Value = "Parameter1Value";
            dynamic h = new ExpandoObject();
            h.MethodName = "TestMethod3";
            h.Key = "Parameter2";
            h.Value = "Parameter2Value";
            dynamic i = new ExpandoObject();
            i.MethodName = "TestMethod3";
            i.Key = "Parameter3";
            i.Value = "Parameter3Value";

            classConfig.Add(a);
            classConfig.Add(b);
            classConfig.Add(c);
            classConfig.Add(d);
            classConfig.Add(e);
            classConfig.Add(f);
            classConfig.Add(g);
            classConfig.Add(h);
            classConfig.Add(i);

            string payload = Newtonsoft.Json.JsonConvert.SerializeObject(classConfig, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(String.Format(@"C:\temp\{0}_Config.json.example", "PortfolioTests"), payload);
        }

        private string GetConfigValue(string methodName, string configKey)
        {
            var jsonConfig = System.IO.File.ReadAllText(String.Format(@"C:\temp\{0}_config.json"
               , this.GetType().Name));

            List<ExpandoObject> configItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonConfig);

            foreach (dynamic d in configItems)
                if (d.MethodName.ToString() == methodName &&
                    d.Key.ToString() == configKey)
                    return d.Value.ToString();

            //return configItems.Cast<ExpandoObject>()
            //  .Where(x => x.MethodName == methodName)
            //  .First(y => y.COnfigKey == configKey);

                   return null;
        }

        private List<ExpandoObject> GetConfigForMethod(string methodName)
        {
            var jsonConfig = System.IO.File.ReadAllText(String.Format(@"C:\temp\{0}_config.json"
               , this.GetType().Name));
            List<ExpandoObject> configItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonConfig);

            //return configItems.Cast<ExpandoObject>()
            //     .Where(x => x.MethodName == methodName);
            List<ExpandoObject> result = new List<ExpandoObject>();

            foreach (dynamic d in configItems)
                if (d.MethodName == methodName)
                    result.Add(d);

            return result;
      
        }

        private KeyValuePair<string,string> GetAuth()
        {
            //auth.Txt should contain something like 
            //Auth: {"UserName":"USERNAME","Password":"PASSWORD"}
            var jsonAuth = System.IO.File.ReadAllText(@"C:\temp\auth.json");
            dynamic secret = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonAuth);
            return new KeyValuePair<string, string>(secret.UserName, secret.Password);
        }
    }
}
