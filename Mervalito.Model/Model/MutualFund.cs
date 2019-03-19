using System;
using Mervalito.Model.Model.Base;

namespace Mervalito.Model.Model
{
    public class MutualFund : BaseDescriptionEntity
    {
        public double Portion { get; set; }
        public double MinimumInvestment { get; set; }
        public int SettlementDeadline { get; set; }
        public Currency Currency { get; set; }
        public CompanyManager CompanyManager { get; set; }
        public InvestmentHorizon InvestmentHorizon { get; set; }
        public DateTime StartDate { get; set; }
        public int LowerDuration { get; set; }
        public int UpperDuration { get; set; }
    }
}
