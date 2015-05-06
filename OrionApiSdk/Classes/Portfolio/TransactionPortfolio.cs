using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrionApiSdk.Classes.Enums;

namespace OrionApiSdk.Classes.Portfolio
{
    public class TransactionPortfolio
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Ticker { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime TransTime { get; set; }
        public decimal TransAmount { get; set; }
        public decimal NavPrice { get; set; }
        public decimal NoUnits { get; set; }
        public int AssetId { get; set; }
        public TradeStatuses Status { get; set; }
        public string TransactionDescription { get; set; }
        public string Notes { get; set; }
        public int TransTypeId { get; set; }
        public int? ContributionCodeId { get; set; }
        public int? DistributionCodeId { get; set; }
        public int AccountId { get; set; }
        public string ManagementStyle { get; set; }
        public int Payee { get; set; }
        public string AdvisorNotes { get; set; }
        public string State { get; set; }
        public DateTime SettleDate { get; set; }
        public string TradeReferenceNumber { get; set; }
        public string TransactionLinkCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDate { get; set; }
        public int RegistrationId { get; set; }
        public int ClientId { get; set; }
        public string TypeCode { get; set; }
        public string TypeSource { get; set; }
        public string SignField { get; set; }
    }
}
