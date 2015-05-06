using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrionApiSdk.Classes.Portfolio
{
    public class TransactionBilling
    {
        public bool IsNMReady { get; set; }
        public bool IsBilled { get; set; }
        public int IsAdvanceBilled { get; set; }
    }
}
