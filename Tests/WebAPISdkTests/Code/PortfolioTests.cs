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
                HandleError(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name
                                   , System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
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

        [TestMethod]
        public void Accounts_CanLimitResultsTest()
        {
            Authenticate();

            var from = DateTime.Parse("07/15/2014");
            var maxRows = 10;
            var actual = OrionApi.Portfolio.Accounts(createdDateStart: from, top: maxRows, isActive: true);
            Assert.IsTrue(actual.Count > 0);

        }


        [TestMethod]
        public void AssetsTest()
        {
            Authenticate();

            var config = GetConfigForMethod(this.GetType().Name, System.Reflection.MethodInfo
                .GetCurrentMethod().Name);

            var accountId = 0;
            var productId = 0;

            foreach (dynamic d in config)
            {
                if (d.Key.ToString() == "AccountId")
                    accountId = int.Parse(d.Value.ToString());
                if (d.Key.ToString() == "ProductId")
                    productId = int.Parse(d.Value.ToString());
            }
               var actual = OrionApi.Portfolio.Assets(accountId: accountId, productId: productId);
                Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod]
        public void Can_Get_AssetsVerbose_Without_Expands()
        {
            Authenticate();

            var config = GetConfigForMethod(this.GetType().Name, System.Reflection.MethodInfo
                .GetCurrentMethod().Name);

            var assetId = 0;
            
            foreach (dynamic d in config)
                if (d.Key.ToString() == "AssetId")
                    assetId = int.Parse(d.Value.ToString());
            try
            {
                var actual = OrionApi.Portfolio.AssetsVerbose(assetId, null);
                Assert.IsNotNull(actual.name);

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(String.Format(@"c:\temp\TestsResults_{0}", DateTime.Today.ToString("MM-yyyy"))
                    , String.Format("{0}.{1}.{2}.E:{3}\n", this.GetType().Name, System.Reflection.MethodInfo.GetCurrentMethod().Name
                    , DateTime.Now.ToString("MM-dd-yyyy_hh:mm:ss"), ex.Message));
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Can_Get_AssetsVerbose_With_Expands_None()
        {
            Authenticate();

            var config = GetConfigForMethod(this.GetType().Name, System.Reflection.MethodInfo
                .GetCurrentMethod().Name);

            var assetId = 0;

            foreach (dynamic d in config)
                if (d.Key.ToString() == "AssetId")
                    assetId = int.Parse(d.Value.ToString());
           
            AssetVerboseOptions? options = AssetVerboseOptions.None;

            try
            {
                var actual = OrionApi.Portfolio.AssetsVerbose(assetId, options);
                Assert.IsNotNull(actual.name);

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(String.Format(@"c:\temp\TestsResults_{0}", DateTime.Today.ToString("MM-yyyy"))
                    , String.Format("{0}.{1}.{2}.E:{3}\n", this.GetType().Name, System.Reflection.MethodInfo.GetCurrentMethod().Name
                    , DateTime.Now.ToString("MM-dd-yyyy_hh:mm:ss"), ex.Message));
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Can_Get_AssetsVerbose_With_Expands()
        {
            //trying to use navigation properties in querystring
            //Why can't I get this to return a known asset?
            Authenticate();

            var config = GetConfigForMethod(this.GetType().Name, System.Reflection.MethodInfo
                .GetCurrentMethod().Name);

            var assetId = 0;

            foreach (dynamic d in config)
                if (d.Key.ToString() == "AssetId")
                    assetId = int.Parse(d.Value.ToString());

            AssetVerboseOptions options = AssetVerboseOptions.Bifurcates;
            options |= AssetVerboseOptions.Billing;
            options |= AssetVerboseOptions.Portfolio;
            options |= AssetVerboseOptions.CostBasisHistories;
            options |= AssetVerboseOptions.CostBasisLots;
            options |= AssetVerboseOptions.EntityOptions;
            options |= AssetVerboseOptions.StepUps;
            options |= AssetVerboseOptions.UserDefinedFields;

            try
            {
                var actual = OrionApi.Portfolio.AssetsVerbose(assetId, options);
                Assert.IsNotNull(actual.name);

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(String.Format(@"c:\temp\TestsResults_{0}", DateTime.Today.ToString("MM-yyyy"))
                    , String.Format("{0}.{1}.{2}.E:{3}\n", this.GetType().Name, System.Reflection.MethodInfo.GetCurrentMethod().Name
                    , DateTime.Now.ToString("MM-dd-yyyy_hh:mm:ss"), ex.Message));
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Can_Get_CashValue_ForAccount()
        {
            Authenticate();

            var config = GetConfigForMethod(this.GetType().Name, System.Reflection.MethodInfo
                .GetCurrentMethod().Name);

            var accountId = 0;
            var productId = 0;

            foreach (dynamic d in config)
            {
                if (d.Key.ToString() == "AccountId")
                    accountId = int.Parse(d.Value.ToString());
                if (d.Key.ToString() == "ProductId")
                    productId = int.Parse(d.Value.ToString());
            }
            var actual = OrionApi.Portfolio.Assets(accountId: accountId, productId: productId);
            Assert.IsTrue(actual.Count.Equals(1));
            Assert.IsTrue(actual[0].currentValue > 0);
        }

        [TestMethod]
        public void Can_Get_Product_By_Id()
        {
            /*
             * {"id":20120,"productName":"Apple Inc","ticker":"AAPL","cusip":"037833100","productType":"Stock/ETF"
             * ,"currentOrionPrice":132.17,"currentOrionPriceDate":"2015-02-24","shareClassName":"0","productCategoryAbbreviation":"E"
             * ,"assetClassDescription":"Large Growth","riskCategoryProductDescriptionProviderName":"Morningstar Sector"
             * ,"assetClassProductDescriptionProviderName":"Morningstar Style Box","editedBy":null,"editedDate":null,"globalFundFamilyId":382
             * ,"globalFundFamilyName":"NFS","defaultPrice":0.0000,"estimatedDividendFrequency":4.0,"expirationDate":null
             * ,"productParentId":null,"productParentName":null,"productSubTypeId":4,"productSubTypeName":"Common Stock"
             * ,"priceStatus":"Normal Daily Pricing","repurchaseBlockDays":0,"shortTermTradeFeeDays":null,"shortTermTradeFeePercent":null
             * ,"strikePrice":0.0,"tradeCutOffTime":null,"tradesPerDay":1,"shareClassDescription":null,"allowIntraDayPerformance":false
             * ,"createdBy":null,"createdDate":null,"moodyRatingId":null,"snpRatingId":null,"assetClassId":456,"assetClassName":"MS Style 3"
             * ,"assetClassLevel":0,"riskCategoryId":135,"riskCategoryName":"Technology","riskCategoryAbbreviation":"311","riskCategoryRank":0
             * ,"hasFees":false,"isAutoAssign":true,"isCustodialCash":false,"isDisabled":false,"isManaged":true,"isUsed":"Used in this database"
             * ,"productStatus":"Open","productCategoryName":"Equity","productCategoryParentCategory":"E","productCategorySortOrder":1
             * ,"riskCategoryProductDescriptionProviderId":5,"assetClassProductDescriptionProviderId":8}
             */
            Authenticate();

            var productId = 20120; //Apple
            var actual = OrionApi.Portfolio.Products(productId);
            Assert.IsTrue(actual.productName == "Apple Inc");

        }

        [TestMethod]
        public void Can_Get_Product_By_Cusip()
        {
            try
            {
                Authenticate();
                Assert.IsTrue(!String.IsNullOrEmpty(OrionApi.AuthToken));
                var cusip = "037833100";
                var actual = OrionApi.Portfolio.Products(exactCusip: cusip);
                Assert.IsNotNull(actual);
                Assert.IsTrue(actual.Count.Equals(1));
                Assert.IsTrue(actual[0].productName == "Apple Inc");
            }
            catch (Exception ex)
            {

                Assert.IsTrue(ex == null);
            }
          
        }

        [TestMethod]
        public void Can_Get_Product_By_Ticker()
        {
            Authenticate();
            var ticker = "AAPL";
            var actual = OrionApi.Portfolio.Products(exactTicker: ticker);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count.Equals(1));
            Assert.IsTrue(actual[0].productName == "Apple Inc");
        }

        [TestMethod]
        public void Can_Get_Transactions_ByDateRange()
        {
            Authenticate();
            var config = GetConfigForMethod(this.GetType().Name, System.Reflection.MethodInfo
               .GetCurrentMethod().Name);

            var from = DateTime.Parse("01/01/2015");
            var to = DateTime.Today;

            foreach (dynamic d in config)
            {
                if (d.Key.ToString() == "From")
                    from = DateTime.Parse(d.Value.ToString());
                if (d.Key.ToString() == "To")
                    to = DateTime.Parse(d.Value.ToString());
            }
            try
            {
                var actual = OrionApi.Portfolio.Transactions(startDate: from, endDate: to);
            Assert.IsTrue(actual.Count > 0);
            }
            catch (Exception ex)
            {
                HandleError(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name
                                   , System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
            
        }

        [TestMethod]
        public void Can_Get_Client_AndThen_SSN()
        {
            //call the client - get teh masked ssn back.
            //call another method to get the actual ssn
            //this is intentional. 
            //We require special privileges and a note indicating the purpose of viewing the ssn.  
            //Each view is logged for compliance, and for this reason, you must retrieve the ssn with a separate call, one at a time.
            //Client SSN:
            //https://testapi.orionadvisor.com/api/Help/Api/PUT-v1-Portfolio-Clients-key-SSNTaxId
            //Registration SSN:
            //https://testapi.orionadvisor.com/api/Help/Api/PUT-v1-Portfolio-Registrations-key-SSNTaxId

        }
    }
}
