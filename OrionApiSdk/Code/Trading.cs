using Newtonsoft.Json;
using OrionApiSdk.Classes;
using OrionApiSdk.Classes.Enums;
using OrionApiSdk.Classes.Trading;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace OrionApiSdk.Code
{
    public class Trading : ApiBase
    {
        internal Trading(HttpClient httpClient) 
            : base(httpClient) { }

        #region Transactions

        public List<OrionApiSdk.Classes.Trading.Transaction> Transactions(int top = 10000, int skip = 0, TradeStatuses? status = null
            ,DateTime? startDate = null ,DateTime? endDate = null, int[] transTypeIds = null)
        {
            var endpoint = new StringBuilder();
            endpoint.AppendFormat(@"Trading/Transactions?$top={0}&$skip={1} &status={2}
                &startDate={3}&endDate={4}", top,skip,status, startDate, endDate);

            if (transTypeIds != null)
                for (int i = 0; i < transTypeIds.Length; i++)
                    endpoint.AppendFormat("&transTypeId{0}={1}", i, transTypeIds[i]);

            var j = base.GetJson(endpoint.ToString());
            var d = JsonConvert.DeserializeObject<List<OrionApiSdk.Classes.Trading.Transaction>>(j);

            return d;
        }

        public OrionApiSdk.Classes.Trading.Transaction Transactions(int Id)
        {
            var endpoint = string.Format("Trading/Transactions/{0}", Id);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<OrionApiSdk.Classes.Trading.Transaction>(j);

            return d;
        }

        public List<DistributionCode> DistributionCodes()
        {
            var endpoint = "Trading/DistributionCodes";
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<DistributionCode>>(j);

            return d;
        }

        public List<Simple> ContributionCodes()
        {
            var endpoint = "Trading/ContributionCodes/Simple";
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Simple>>(j);

            return d;
        }
        #endregion

    }
}
