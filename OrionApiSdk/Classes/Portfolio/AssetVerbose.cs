using System;
using OrionApiSdk.Classes.Enums;
using System.Collections.Generic;

namespace OrionApiSdk.Classes.Portfolio
{

    public class UnrealizedAssetCost
    {
        public DateTime asOfDate { get; set; }
        public decimal longTermCost { get; set; }
        public decimal shortTermCost { get; set; }
        public decimal longTermUnits { get; set; }
        public decimal shortTermUnits { get; set; }
        public DateTime aquiredDate { get; set; }
        public decimal amoritizationAmt { get; set; }
        public decimal costPerShare { get; set; }
    }


    public class CostBasisHistory
    {
        public int id { get; set; }
        public DateTime aquiredDate { get; set; }
        public DateTime sellDate { get; set; }
        public DateTime holdingPeriodDate { get; set; }
        public decimal costAmount { get; set; }
        public decimal numberOfUnits { get; set; }
        public string method { get; set; }
        public decimal proceedAmount { get; set; }
        public DateTime importedDate { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public string editedBy { get; set; }
        public string editedDate { get; set; }
    }

    public class Bifurcate
    {
        public int id { get; set; }
        public DateTime startDate { get; set; }
        public int method { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public string editedBy { get; set; }
        public string editedDate { get; set; }
    }

    public class StepUp
    {
        public int id { get; set; }
        public decimal percent { get; set; }
        public DateTime date { get; set; }
        public decimal unitPrice { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public string editedBy { get; set; }
        public string editedDate { get; set; }
    }

    public class AssetBilling
    {
        public int billAssetId { get; set; }
        public bool isFeeIncluded { get; set; }
        public bool isPayingFee { get; set; }
        public decimal excludeAmount { get; set; }
        public ExcludeAmountTypes excludeAmountType { get; set; }
        public Entity excludePercentOf { get; set; }
        public DateTime excludeEndDate { get; set; }
        public DateTime excludeStartDate { get; set; }
    }

    public class AssetPortfolio
    {
        public string name { get; set; }
        public string accountNumber { get; set; }
        public decimal currentShares { get; set; }
        public decimal currentValue { get; set; }
        public string ticker { get; set; }
        public bool isManaged { get; set; }
        public string secondaryAccountNumber { get; set; }
        public string cusip { get; set; }
        public int productId { get; set; }
        public string assetClass { get; set; }
        public bool isCustodialCash { get; set; }
        public int assetLevelStrategyId { get; set; }
        public int status { get; set; }
        public string createdBy { get; set; }
        public DateTime createdDate { get; set; }
        public string editedBy { get; set; }
        public DateTime editedDate { get; set; }
        public int accountId { get; set; }
        public int registrationId { get; set; }
        public int clientId { get; set; }
        public bool isActive { get; set; }
        public int downloadSymbol { get; set; }
        public bool isStrategyOverride { get; set; }

    }

    public class AssetVerbose
    {
        public int id { get; set; }
        public string name { get; set; }
        public AssetPortfolio portfolio { get; set; }
        public AssetBilling billing { get; set; }
        public List<StepUp> stepUps { get; set; }
        public List<Bifurcate> bifurcates { get; set; }
        public List<CostBasisHistory> costBasisHistories { get; set; }
        public List<UnrealizedAssetCost> costBasisLots { get; set; }
        public List<EntityOption> userDefinedFields { get; set; }
        public List<EntityOption> entityOptions { get; set; }
    }
}
