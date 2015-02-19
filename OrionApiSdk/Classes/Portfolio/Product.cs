using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Ticker { get; set; }
        public string Cusip { get; set; }
        public OrionApiSdk.Classes.Enums.ProductTypes ProductType { get; set; }
        public decimal CurrentOrionPrice { get; set; }
        public DateTime CurrentOrionPriceDateTime { get; set; }
        public string ShareClassName { get; set; }
        public string ProductCategoryAbbreviation { get; set; }
        public string AssetClassDescription { get; set; }
        public string RiskCategoryProductDescriptionProviderName { get; set; }
        public string AssetClassProductDescriptionProviderName { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDateTime { get; set; }
        public int GlobalFundFamilyId { get; set; }
        public string GlobalFundFamilyName { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal EstimatedDividendFrequency { get; set; }
        public DateTime ExpirationDateTime { get; set; }
        public int ProductParentId { get; set; }
        public string ProductParentName { get; set; }
        public int ProductSubTypeId { get; set; }
        public string ProductSubTypeName { get; set; }
        public OrionApiSdk.Classes.Enums.PricingStatus PriceStatus { get; set; }
        public int RepurchaseBlockDays { get; set; }
        public int ShortTermTradeFeeDays { get; set; }
        public decimal ShortTermTradeFeePercent { get; set; }
        public decimal StrikePrice { get; set; }
        public DateTime TradeCutOffTime { get; set; }
        public int TradesPerDay { get; set; }
        public string ShareClassDescription { get; set; }
        public bool AllowIntraDayPerformance { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int MoodyRatingId { get; set; }
        public int SnPRatingId { get; set; }
        public int AssetClassId { get; set; }
        public string AssetClassName { get; set; }
        public int AssetClassLevel { get; set; }
        public int RiskCategoryId { get; set; }
        public string RiskCategoryName { get; set; }
        public string RiskCategoryAbbreviation { get; set; }
        public int RiskCategoryRank { get; set; }
        public bool HasFees { get; set; }
        public bool IsAutoAssign { get; set; }
        public bool IsCustodialCash { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsManaged { get; set; }
        public OrionApiSdk.Classes.Enums.ProductUses IsUsed { get; set; }
        public OrionApiSdk.Classes.Enums.ProductStatus ProductStatus { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductCategoryParentCategory { get; set; }
        public int ProductCategorySortOrder { get; set; }
        public int RiskCategoryProductDescriptionProviderId { get; set; }
        public int AssetClassProductDescriptionProviderId { get; set; }
        public string OrionSub { get; set; }
        public string OrionCat { get; set; }
        public string MorningstarSector { get; set; }
        public string MorningstarGroup { get; set; }
        public string MorningstarIndustry { get; set; }
        public string MorningstarStyle { get; set; }
        public string MorningstarCategoryCode { get; set; }
        public string MorningstarCategory { get; set; }
        public string LipperIOBClass { get; set; }
        public string LipperIOBDescription { get; set; }
        public string LipperIOBCategory { get; set; }
        public string LipperClass { get; set; }
        public string LipperClassDescription { get; set; }
        public string LipperClassCategory { get; set; }
        public string ValueLineAbbrev { get; set; }
        public string ValueLineDesc { get; set; }

    }
}
