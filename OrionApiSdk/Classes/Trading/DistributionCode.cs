using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrionApiSdk.Classes.Trading
{
    public class DistributionCode
    {
        public int id { get; set; }
        public int extId { get; set; }
        public string distCode { get; set; }
        public string taxCode { get; set; }
        public string fedCode { get; set; }
        public string description { get; set; }
        public string transDesc { get; set; }
        public string distDesc { get; set; }
        public string taxDesc { get; set; }
        public bool isValid { get; set; }
        public bool isQualified { get; set; }
    }
}
