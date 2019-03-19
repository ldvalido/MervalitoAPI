using System.Web.Http;
using Mervalito.Domain.Base;

namespace Mervalito.API.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TS">The type of the s.</typeparam>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class BaseCRUDApiController<T, TS> : ApiController where T : class
    {
        /// <summary>
        /// The crud service
        /// </summary>
        protected ICrudService<T, TS> crudService;
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseCRUDApiController{T, TS}"/> class.
        /// </summary>
        /// <param name="crudService">The crud service.</param>
        public BaseCRUDApiController(ICrudService<T, TS> crudService)
        {
            this.crudService = crudService;
        }
    }
}