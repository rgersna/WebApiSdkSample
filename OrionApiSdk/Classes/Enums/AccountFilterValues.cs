using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Enums
{
    public enum AccountFilterValues
    {
        MissingInformation = 1,
        ActiveAccountsWithZeroBalance = 2,
        InactiveAccountsNotZero = 3,
        AcctsWithMultAcctNumbersPerAcctId = 4,
        SameAcctNumberInMultAccounts = 5,
        MissingMgmtStyle = 6,
        LinkedToHistoryAccountWithValue = 7,
        LinkedWithRecursiveLink = 8,
        LinkedInDifferentRegistrations = 9,
        LinkedWithNoTransactions = 10,
        StrewnAcrossMultipleAccounts = 11,
        FundFamilyVsCustodianComparison = 12
 
    }
}
