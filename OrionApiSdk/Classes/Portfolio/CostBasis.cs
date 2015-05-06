using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrionApiSdk.Classes.Portfolio
{
    public class CostBasis
    {
        public int Id { get; set; }
        public DateTime CostDate { get; set; }
        public DateTime HoldingPeriodDate { get; set; }
        public decimal CostUnits { get; set; }
        public decimal CostPrice { get; set; }
        public decimal CostTotal { get; set; }
        public string CostNotes { get; set; }
        public int TransTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime EditedDate { get; set; }
    }
}
