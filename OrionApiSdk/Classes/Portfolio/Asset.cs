using OrionApiSdk.Classes.Enums;
using System;
namespace OrionApiSdk.Classes.Portfolio
{
    public class Asset
    {
        public int id { get; set; }
        public string name { get; set; }
        public string accountNumber { get; set; }
        public string ticker { get; set; }
        public decimal currentShares { get; set; }
        public decimal currentValue { get; set; }
        public decimal currentPrice { get; set; }
        public bool isManaged { get; set; }
        public string assetClass { get; set; }
        public bool isCustodialCash { get; set; }
        public string secondaryAccountNumber { get; set; }
        public string cusip { get; set; }
        public int productId { get; set; }
        public int? assetLevelStrategyId { get; set; }
        public string assetLevelStrategy { get; set; }
        public int status { get; set; }
        public bool isStrategyOverride { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public string editedBy { get; set; }
        public DateTime editedDate { get; set; }
        public int accountId { get; set; }
        public int registrationId { get; set; }
        public int clientId { get; set; }
        public bool isActive { get; set; }
        public int downloadSymbol { get; set; }
        public string accountType { get; set; }
        public string fundFamily { get; set; }
        public string custodian { get; set; }
        public DateTime? asOfDate { get; set; }
       // public ProductTypes productType { get; set; } "Stock/ETF"
        public string ProductType { get; set; }
        public decimal? costBasis { get; set; }

    }
}
