using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Mervalito.Storage.Context;

namespace Mervalito.Storage.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class StorageBase<T,TS> : IStorageBase<T,TS> where T : class
    {
        /// <summary>
        /// Gets or sets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        public MervalitoContext DbContext { get; set; }

        #region Astract Methods        
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerable<T> GetList()
        {
            return DbContext.Set<T>();
        }
        #endregion

        #region Public Methods        
        /// <summary>
        /// Saves the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public T Save(T element)
        {
            var returnValue = DbContext.Set<T>().Add(element);
            DbContext.SaveChanges();
            return returnValue;
        }
        /// <summary>
        /// Updates the specified element.
        /// </summary>
        /// <param name="Element">The element.</param>
        public T Update(T entity)
        {
            var set = DbContext.Set<T>();
            set.Attach(entity);
            var entry = DbContext.Entry(entity);
            entry.State = EntityState.Modified;
            DbContext.SaveChanges();
            return entity;

        }
        /// <summary>
        /// Removes the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public T Remove(T element)
        {
            var returnValue = DbContext.Set<T>().Remove(element);
            DbContext.SaveChanges();
            return returnValue;
        }
        /// <summary>
        /// Gets the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public virtual T Get(TS value)
        {
            T returnValue;
            using (var ctx = new MervalitoContext())
            {
                returnValue = ctx.Set<T>().Find(value);
            }

            return returnValue;
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return GetList();
        }
        /// <summary>
        /// Gets the by criteria.
        /// </summary>
        /// <param name="fncCriteria">The FNC criteria.</param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetByCriteria(Func<T, bool> fncCriteria)
        {
            return GetList().Where(fncCriteria);
        }
        #endregion
    }
}
