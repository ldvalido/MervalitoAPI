using System;
using System.Collections.Generic;
using System.Linq;
using Mervalito.Model.Model;
using Mervalito.Storage.Base;
using Mervalito.Storage.Context;

namespace Mervalito.Storage.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    public class TitleStorage : StorageBase<Title,int>
    {
        #region Overrides of StorageBase<Title>

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Title> GetAll()
        {
            return this.DbContext.Set<Title>().
                Include("BondType").
                Include("PaymentPeriod").
                Include("Currency").
                Include("RentType").
                Include("TitleType");
        }

        #region Overrides of StorageBase<Title,int>

        /// <summary>
        /// Gets the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override Title Get(int value)
        {
            using (var ctx = new MervalitoContext())
            {
                var entry = ctx.Set<Title>().Find(value);
                ctx.Entry(entry).Reference(t=>t.BondType).Load();
                ctx.Entry(entry).Reference(t=>t.RentType).Load();
                ctx.Entry(entry).Reference(t=>t.PaymentPeriod).Load();
                ctx.Entry(entry).Reference(t => t.Currency).Load();
                ctx.Entry(entry).Reference(t => t.TitleType).Load();
                return entry;
            }
        }

        #endregion

        #endregion

        #region Overrides of StorageBase<Title,int>

        /// <summary>
        /// Gets the by criteria.
        /// </summary>
        /// <param name="fncCriteria">The FNC criteria.</param>
        /// <returns></returns>
        public override IEnumerable<Title> GetByCriteria(Func<Title, bool> fncCriteria)
        {
            return GetAll().Where(fncCriteria);
        }

        #endregion
    }
}
