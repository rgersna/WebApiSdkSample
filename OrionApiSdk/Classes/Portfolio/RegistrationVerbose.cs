using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{


    public class RegistrationVerbose
    {
        public int? id { get; set; }
        public string name { get; set; }
        public RegistrationPortfolio portfolio { get; set; }
        public RegistrationNotes[] notes { get; set; }
        public RegistrationBeneficiary[] beneficiaries { get; set; }
        public RegistrationSuitability suitability { get; set; }
        public EntityOption[] userDefinedFields { get; set; }
        public EntityOption[] entityOptions { get; set; }
    }

    public class RegistrationPortfolio
    {
        public string name { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string typeCode { get; set; }
        public string accountType { get; set; }
        public bool isActive { get; set; }
        public int? clientId { get; set; }
        public int? typeId { get; set; }
        public string company { get; set; }
        public string jobTitle { get; set; }
        public string ssN_TaxID { get; set; }
        public DateTime? dob { get; set; }
        public string gender { get; set; }
        public string createdBy { get; set; }
        public DateTime? createdDate { get; set; }
        public string editedBy { get; set; }
        public DateTime? editedDate { get; set; }
        public object dateOfDeath { get; set; }
    }

    public class RegistrationSuitability
    {
        public string netWorthIncludingResidence { get; set; }
        public string netWorthExcludingResidence { get; set; }
        public string liquidNetWorth { get; set; }
        public string investmentKnowledge { get; set; }
        public string riskExposure { get; set; }
        public string investmentExperience { get; set; }
        public string returnObjective { get; set; }
        public string investmentObjective { get; set; }
        public string timeHorizon { get; set; }
        public string stockPercent { get; set; }
        public decimal riskTolerance { get; set; }
        public decimal netWorth { get; set; }
        public decimal netIncome { get; set; }
        public string riskBudget { get; set; }
        public bool isLifestyleOption { get; set; }
    }

    public class RegistrationNotes
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDate { get; set; }
        public string Category { get; set; }
        public bool IsWebVisible { get; set; }
    }

    public class RegistrationBeneficiary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Type { get; set; }
        public string Relation { get; set; }
        public decimal Percentage { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string SSN { get; set; }
        public string Reason { get; set; }
    }

    public class EntityOptions
    {
        public EntityOption Entity { get; set; }
        public int EquityId { get; set; }
        public string EntityName { get; set; }
        public int UserDefineDefinitionId { get; set; }
        public int UserDefineDataId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Type { get; set; }
        public string Code { get; set; }
        public int Sequence { get; set; }
        public string Value { get; set; }
        public object Options { get; set; }
        public string Input { get; set; }
        public string ChildParameter { get; set; }
    }
}
