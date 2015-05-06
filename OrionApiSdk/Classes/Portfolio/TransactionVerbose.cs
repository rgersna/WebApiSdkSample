using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrionApiSdk.Classes.Portfolio
{
    public class TransactionVerbose
    {
        public int Id { get; set; }
        public TransactionPortfolio Portfolio { get; set; }
        public TransactionBilling Billing { get; set; }
        public CostBasis CostBasis { get; set; }
        public PortfolioTransactionAdditionalInformation AdditionalInformation { get; set; }
        public EntityOption UserDefinedFields { get; set; }
        public EntityOption EntityOptions { get; set; }
    }
}
