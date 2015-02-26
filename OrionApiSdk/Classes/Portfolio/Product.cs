using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{
    public class Product
    {
        public int id { get; set; }
        public string productName { get; set; }
        public string ticker { get; set; }
        public string cusip { get; set; }
        //public OrionApiSdk.Classes.Enums.ProductTypes productType { get; set; }
        public string productType { get; set; }
        public decimal currentOrionPrice { get; set; }
        public DateTime currentOrionPriceDate { get; set; }
        public string shareClassName { get; set; }
        public string productCategoryAbbreviation { get; set; }
        public string assetClassDescription { get; set; }
        public string riskCategoryProductDescriptionProviderName { get; set; }
        public string assetClassProductDescriptionProviderName { get; set; }
        public string editedBy { get; set; }
        public DateTime? editedDate { get; set; }
        public int globalFundFamilyId { get; set; }
        public string globalFundFamilyName { get; set; }
        public decimal defaultPrice { get; set; }
        public decimal estimatedDividendFrequency { get; set; }
        public DateTime? expirationDate { get; set; }
        public int? productParentId { get; set; }
        public string productParentName { get; set; }
        public int productSubTypeId { get; set; }
        public string productSubTypeName { get; set; }
        //public OrionApiSdk.Classes.Enums.PricingStatus priceStatus { get; set; }
        public string PriceStatus { get; set; }
        public int repurchaseBlockDays { get; set; }
        public int? shortTermTradeFeeDays { get; set; }
        public decimal? shortTermTradeFeePercent { get; set; }
        public decimal strikePrice { get; set; }
        public DateTime? tradeCutOffTime { get; set; }
        public int tradesPerDay { get; set; }
        public string shareClassDescription { get; set; }
        public bool allowIntraDayPerformance { get; set; }
        public string createdBy { get; set; }
        public DateTime? createdDate { get; set; }
        public int? moodyRatingId { get; set; }
        public int? snPRatingId { get; set; }
        public int assetClassId { get; set; }
        public string assetClassName { get; set; }
        public int assetClassLevel { get; set; }
        public int riskCategoryId { get; set; }
        public string riskCategoryName { get; set; }
        public string riskCategoryAbbreviation { get; set; }
        public int riskCategoryRank { get; set; }
        public bool hasFees { get; set; }
        public bool isAutoAssign { get; set; }
        public bool isCustodialCash { get; set; }
        public bool isDisabled { get; set; }
        public bool isManaged { get; set; }
        //public OrionApiSdk.Classes.Enums.ProductUses isUsed { get; set; }
        public string isUsed { get; set; }
        public OrionApiSdk.Classes.Enums.ProductStatus productStatus { get; set; }
        public string productCategoryName { get; set; }
        public string productCategoryParentCategory { get; set; }
        public int productCategorySortOrder { get; set; }
        public int riskCategoryProductDescriptionProviderId { get; set; }
        public int assetClassProductDescriptionProviderId { get; set; }
        public string orionSub { get; set; }
        public string orionCat { get; set; }
        public string morningstarSector { get; set; }
        public string morningstarGroup { get; set; }
        public string morningstarIndustry { get; set; }
        public string morningstarStyle { get; set; }
        public string morningstarCategoryCode { get; set; }
        public string morningstarCategory { get; set; }
        public string lipperIOBClass { get; set; }
        public string lipperIOBDescription { get; set; }
        public string lipperIOBCategory { get; set; }
        public string lipperClass { get; set; }
        public string lipperClassDescription { get; set; }
        public string lipperClassCategory { get; set; }
        public string valueLineAbbrev { get; set; }
        public string valueLineDesc { get; set; }

    }
}
