using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Enums
{
    public enum PricingStatus
    {
        Normal = 0,
        Default = 1,
        Manual = 2,
        ReceivedMoreThan1Day = 3,
        InfrequentPricing = 4,
        SecurityIsWorthless = 5,
        IndeterminableValue = 6,
        NotActiveProduct = 7
    }
}
