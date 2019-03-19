using System;
using System.Collections.Generic;
using Mervalito.Model.Model;
using Mervalito.Storage.Base;
using Mervalito.Storage.Context;

namespace Mervalito.Storage.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Mervalito.Storage.Base.StorageBase{Mervalito.Model.Model.CompanyManager, System.Int32}" />
    public class CautionStorage : StorageBase<Caution, int>
    {
        #region Overrides of StorageBase<Caution,int>

        /// <summary>
        /// Gets the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override Caution Get(int value)
        {
            using (var ctx = new MervalitoContext())
            {
                var entry = ctx.Set<Caution>().Find(value);
                ctx.Entry(entry).Reference(t => t.Currency).Load();
                return entry;
            }
        }

        #endregion

        #region Overrides of StorageBase<Caution,int>

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Caution> GetAll()
        {
            return this.DbContext.Set<Caution>().Include("Currency");
        }

        #endregion

        #region Overrides of StorageBase<Caution,int>

        /// <summary>
        /// Gets the by criteria.
        /// </summary>
        /// <param name="fncCriteria">The FNC criteria.</param>
        /// <returns></returns>
        public override IEnumerable<Caution> GetByCriteria(Func<Caution, bool> fncCriteria)
        {
            return this.DbContext.Set<Caution>().
                Include("Currency");
        }

        #endregion
    }
}
