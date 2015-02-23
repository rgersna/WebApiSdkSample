using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace OrionApiSdk.Tests
{
    public class TestBase
    {

        //Proxy usage notes:
        //1) The proxy layer asserts EnsureSuccessStatusCode - so we need to trap the exception
        //   if a login error occurs
        //2) Trading.Transactions needs nullables for ContributionId and DistributionId 
        //3) Proxy defaults to OrionEnvironment.Test if you pass null for environment. If you have a sample DB in production
        //   add a config item named Environment to auth to change the environment.
        //4) Proxy defaults to OrionAPI Url. To override  - add parameters to auth named BaseUrl and ConnectUrl
        //5)
        //6)



        /// <summary>
        /// Use this method to generate a auth template for the REST API
        /// activate the template by removing the .example file extension
        /// This template should contain your username and password for the API
        /// and should not be in source control.
        /// Rename it to auth.json to use the file to authenticate
        /// </summary>
        [TestMethod]
        public void Utility_GenerateAuth()
        {
            dynamic d = new ExpandoObject();
            d.UserName = "USERNAME";
            d.Password = "PASSWORD";
            d.Environment = "Test";
            string payload = Newtonsoft.Json.JsonConvert.SerializeObject(d);
            System.IO.File.WriteAllText(@"C:\temp\Auth.json.example", payload);
        }

        /// <summary>
        /// Use this method to generate a configuration template for the test class
        /// activate the template by removing the .example file extension
        /// This template should contain all variables specific to your installation of
        /// Orion, and should not of course be in source control
        /// Rename to CLASSNAME_config.json to use the file against the unti tests
        /// </summary>
        [TestMethod]
        public void Utility_GenerateTestConfig()
        {

            var classConfig = new List<ExpandoObject>();
            var configItem = new ExpandoObject(); 

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
            System.IO.File.WriteAllText(String.Format(@"C:\temp\{0}_Config.json.example", "CLASSNAME"), payload);
        }

        protected string GetConfigValue(string className, string methodName, string configKey)
        {
            var jsonConfig = System.IO.File.ReadAllText(String.Format(@"C:\temp\{0}_config.json"
               , className));

            List<ExpandoObject> configItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonConfig);

            foreach (dynamic d in configItems)
                if (d.MethodName.ToString() == methodName &&
                    d.Key.ToString() == configKey)
                    return d.Value.ToString();

            //return configItems.Cast<ExpandoObject>()
            //  .Where(x => x.MethodName == methodName)
            //  .First(y => y.COnfigKey == configKey).ToString();

            return null;
        }

        protected List<ExpandoObject> GetConfigForMethod(string className, string methodName)
        {
            var jsonConfig = System.IO.File.ReadAllText(String.Format(@"C:\temp\{0}_config.json"
               , className));
            List<ExpandoObject> configItems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonConfig);

            //return configItems.Cast<ExpandoObject>()
            //     .Where(x => x.MethodName == methodName);
            List<ExpandoObject> result = new List<ExpandoObject>();

            foreach (dynamic d in configItems)
                if (d.MethodName.ToString() == methodName)
                    result.Add(d);

            return result;

        }

        protected void Authenticate()
        {
            //auth.Txt should contain something like 
            //{"UserName":"USERNAME","Password":"PASSWORD", "Environment":"Test"}
            var jsonAuth = System.IO.File.ReadAllText(@"C:\temp\auth.json").Trim();
            dynamic secret = Newtonsoft.Json.Linq.JObject.Parse(jsonAuth);
            OrionApi.Authenticate(secret.UserName.ToString(),secret.Password.ToString(),
                (OrionApiSdk.Classes.Enums.OrionEnvironment)Enum.Parse(typeof(OrionApiSdk.Classes.Enums.OrionEnvironment), secret.Environment.ToString()));
        }

        protected void HandleError(string methodName, Exception ex)
        {
            var msg = String.Empty;
            if (!String.IsNullOrEmpty(ex.Message))
            {
                if (ex.Message.Contains("{"))
                {
                    dynamic apiResult = Newtonsoft.Json.JsonConvert.DeserializeObject(ex.Message);
                    msg = String.Format("ApiResult: {0}. Error: {1}, Details: {2}, Trace:{3}",
                        apiResult.UserException.Detail.ToString(), ex.Message, ex.InnerException, ex.StackTrace);
                }
                else
                {
                    msg = ex.Message;
                }
            }
            var file =
                String.Format(@"C:\Temp\OrionApiSdk.Code.Tests.{0}.{1}_Errors{2}.mstest"
                , this.GetType().Name
                , methodName
                , DateTime.Now.ToString("mmDDYYhhmmsss"));
            System.IO.File.WriteAllText(file, msg);
            Assert.Fail(msg);
        }

    }
}
