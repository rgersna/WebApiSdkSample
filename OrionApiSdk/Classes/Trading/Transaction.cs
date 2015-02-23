using OrionApiSdk.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Trading
{
    /// <summary>
    /// https://api.orionadvisor.com/api/Help/ResourceModel?modelName=OAS.WebApi.DTO.Trading.TradingTransactionDto
    /// </summary>
    public class Transaction
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public string ProductName { get; set; }
        public string Ticker { get; set; }
        public int AccountId { get; set; }
        public string AccountNumber { get; set; }
        public int RegistrationId { get; set; }
        public string RegistrationName { get; set; }
        public string RegistrationCode { get; set; }
        public int HouseholdId { get; set; }
        public string FundFamilyName { get; set; }
        public string CustodianName { get; set; }
        public TradeStatuses Status { get; set; }
        public DateTime TransDateTime { get; set; }
        public string TransactionDescription { get; set; }
        public decimal TransAmount { get; set; }
        public decimal NavPrice { get; set; }
        public decimal NoUnits { get; set; }
        public string Notes { get; set; }
        public string OrderId { get; set; }
        public int BlockId { get; set; }
        public string OrderCreatedBy { get; set; }
        public decimal AvgPrice { get; set; }
        public DateTime ExecutionTime { get; set; }
        public int TransTypeId { get; set; }
        public int? ContributionCodeId { get; set; }
        public int? DistributionCodeId { get; set; }
        public int ClientId { get; set; }
    }
}