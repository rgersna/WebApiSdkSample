using OrionApiSdk.Classes.Enums;
using System;

namespace OrionApiSdk.Classes.Portfolio
{
   public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransDate { get; set; }
        public string TransactionDescription { get; set; }
        public string ProductName { get; set; }
        public string Ticker { get; set; }
        public decimal TransAmount { get; set; }
        public decimal NoUnits { get; set; }
        public decimal NavPrice { get; set; }
        public string AccountNumber { get; set; }
        public TradeStatuses Status { get; set; }
        public string Type { get; set; }
        public DateTime? TransTime { get; set; }
        public int AssetId { get; set; }
        public string Cusip { get; set; }
        public string Notes { get; set; }
        public int TransTypeId { get; set; }
        public int? ContributionCodeId { get; set; }
        public int? DistributionCodeId { get; set; }
        public int AccountId { get; set; }
        public string ManagementStyle { get; set; }
        public int? Payee { get; set; }
        public string AdvisorNotes { get; set; }
        public string State { get; set; }
        public DateTime? SettleDate { get; set; }
        public string TradeReferenceNumber { get; set; }
        public string TransactionLinkCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDate { get; set; }
        public int RegistrationId { get; set; }
        public int ClientId { get; set; }
        public string TypeCode { get; set; }
        public string BrokerCode { get; set; }
        public string AccountType { get; set; }
        public string FundFamily { get; set; }
        public string Custodian { get; set; }
        public int Count { get; set; }
        public decimal UnitBalance { get; set; }
        public string SortOrder { get; set; }
    }
}
