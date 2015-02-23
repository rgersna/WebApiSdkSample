using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using OrionApiSdk.Classes.Portfolio;
using OrionApiSdk.Classes.Trading;
using System;

namespace OrionApiSdk.Code
{
    public class Trading : ApiBase
    {
        internal Trading(HttpClient httpClient) 
            : base(httpClient) { }

        #region Transactions

        public List<Transaction> Transactions(DateTime startDate, DateTime endDate)
        {
            var endpoint = string.Format("Trading/Transactions?startDate={0}&endDate={1}", startDate,endDate);
            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<List<Transaction>>(j);

            return d;
        }

        public Transaction Transactions(int Id)
        {
            var endpoint = string.Format("Trading/Transactions/{0}", Id);

            var j = base.GetJson(endpoint);
            var d = JsonConvert.DeserializeObject<Transaction>(j);

            return d;
        }

        #endregion

    }
}
