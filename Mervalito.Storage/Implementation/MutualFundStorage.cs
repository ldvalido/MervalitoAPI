using System.Collections.Generic;
using Mervalito.Model.Model;
using Mervalito.Storage.Base;
using Mervalito.Storage.Context;

namespace Mervalito.Storage.Implementation
{
    public class MutualFundStorage :  StorageBase<MutualFund, int>
    {
        #region Overrides of StorageBase<MutualFundStorage,int>

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<MutualFund> GetAll()
        {

            return this.DbContext.Set<MutualFund>().
                Include("Currency").
                Include("CompanyManager").
                Include("InvestmentHorizon");
        }

        #endregion

        #region Overrides of StorageBase<MutualFund,int>

        /// <summary>
        /// Gets the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override MutualFund Get(int value)
        {

            using (var ctx = new MervalitoContext())
            {
                var entry = ctx.Set<MutualFund>().Find(value);
                ctx.Entry(entry).Reference(t => t.Currency).Load();
                ctx.Entry(entry).Reference(t => t.CompanyManager).Load();
                ctx.Entry(entry).Reference(t => t.InvestmentHorizon).Load();
                return entry;
            }
        }

        #endregion
    }
}
