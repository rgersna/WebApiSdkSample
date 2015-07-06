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
        public int id { get; set; }
        public string text { get; set; }
        public string editedBy { get; set; }
        public DateTime editedDate { get; set; }
        public string category { get; set; }
        public bool isWebVisible { get; set; }
    }

    public class RegistrationBeneficiary
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime? dob { get; set; }
        public string type { get; set; }
        public string relation { get; set; }
        public decimal percentage { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string ssN_TaxID { get; set; }
        public string reason { get; set; }
    }
}
