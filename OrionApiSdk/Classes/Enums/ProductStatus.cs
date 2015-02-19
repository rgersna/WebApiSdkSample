using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Enums
{
    public enum ProductStatus
    {   
        Open = 0,
        SoftClose = 1,
        HardClose = 2,
        SellOnly = 3,
        PurchaseOnly = 4,
        Exclude = 5 
    }
}