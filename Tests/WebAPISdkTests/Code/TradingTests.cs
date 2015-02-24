using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrionApiSdk.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrionApiSdk.Classes.Enums;
using System.Dynamic;

namespace OrionApiSdk.Tests
{
    [TestClass()]
    public class TradingTests : TestBase
    {
        [TestMethod()]
        public void TransactionsTest()
        {
            var startDate = DateTime.MinValue;
            var toDate = DateTime.MinValue;
            var expected = 1;

            #region GetTestData
            
            var config = GetConfigForMethod(this.GetType().Name, System.Reflection.MethodInfo
                .GetCurrentMethod().Name);

            foreach (dynamic d in config)
            {
                if (d.Key.ToString() == "StartDate")
                    startDate = DateTime.Parse(d.Value.ToString());
                if (d.Key.ToString() == "EndDate")
                    toDate = DateTime.Parse(d.Value.ToString());
            }
            #endregion

            try
            {
                Authenticate();
                var actual = OrionApi.Trading.Transactions(status: TradeStatuses.Complete, startDate: startDate, endDate: toDate);
                Assert.IsTrue(expected < actual.Count);
            }
            catch (Exception ex)
            {
                HandleError(System.Reflection.MethodInfo.GetCurrentMethod().Name, ex);
            }
        }

        [TestMethod()]
        public void TransactionByIdTest()
        {

            var id = 0;
            var expected = 0;
            var config = GetConfigForMethod(this.GetType().Name, System.Reflection.MethodInfo
                .GetCurrentMethod().Name);

            foreach (dynamic d in config)
                if (d.Key.ToString() == "TransactionId")
                    id = int.Parse(d.Value.ToString());
            try
            {
                Authenticate();
                var actual = OrionApi.Trading.Transactions(id);
                Assert.IsTrue(actual.TransAmount > expected);
            }
            catch (Exception ex)
            {
                HandleError(System.Reflection.MethodInfo.GetCurrentMethod().Name, ex);
                Assert.Fail();
            }
        }
 
    }
}
