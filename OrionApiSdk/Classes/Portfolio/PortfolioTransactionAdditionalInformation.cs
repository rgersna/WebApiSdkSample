using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrionApiSdk.Classes.Portfolio
{
    public class PortfolioTransactionAdditionalInformation
    {
        public Decimal YieldToMaturity { get; set; }
        public bool IsOID { get; set; }
        public int TradeRequestId { get; set; }
        public int CommIndicator { get; set; }
        public int OrderType { get; set; }
        public int MarketCode { get; set; }
        public int BlotterCode { get; set; }
        public int DistIndicator { get; set; }
        public int RevenueType { get; set; }
        public int SpreadStraddle { get; set; }
        public string BrokerCode { get; set; }
        public bool IncludeAsRmdDistribution { get; set; }
        public bool IncludeAsRmdDistributionIsSystemMaintained { get; set; }
    }
}
