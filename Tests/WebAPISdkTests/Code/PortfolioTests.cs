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
            Authenticate();
            var cusip = "037833100";
            var actual = OrionApi.Portfolio.Products(exactCusip: cusip);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count.Equals(1));
            Assert.IsTrue(actual[0].productName == "Apple Inc");
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
    }
}
