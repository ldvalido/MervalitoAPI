using System;
using System.Collections.Generic;

namespace Mervalito.Domain.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TS"></typeparam>
    public interface ICrudService<T,TS> where T : class
    {
        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        T Create(T entity);
        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        T Delete(T entity);
        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        T Get(TS key);

        /// <summary>
        /// Gets the by.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <returns></returns>
        T GetBy(Func<T, bool> func);
        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> List();
        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        T Update(T entity);

    }
}