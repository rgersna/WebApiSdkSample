using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Enums
{
    [Flags]
    public enum AssetVerboseOptions
    {
        None = 0,
        Billing = 1,
        Portfolio = 2,
        StepUps = 4,
        Bifurcates = 8,
        CostBasisHistories = 16,
        CostBasisLots = 32,
        UserDefinedFields = 64,
        EntityOptions = 128,
        All = 255
    }
}
