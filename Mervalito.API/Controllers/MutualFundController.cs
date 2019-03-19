using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Mervalito.API.Base;
using Mervalito.Domain.Base;
using Mervalito.Domain.Implementation;
using Mervalito.Model.Model;

namespace Mervalito.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("")]
    public class MutualFundController : BaseCRUDApiController<MutualFund,int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MutualFundController"/> class.
        /// </summary>
        /// <param name="crudService"></param>
        public MutualFundController(ICrudService<MutualFund, int> crudService) : base(crudService)
        {
        }

        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [Route("MutualFunds")]
        [HttpGet]
        public List<MutualFund> List()
        {
            return crudService.List().ToList();
        }
        /// <summary>
        /// Gets the specified identifier mutual fund.
        /// </summary>
        /// <param name="idMutualFund">The identifier mutual fund.</param>
        /// <returns></returns>
        [Route("MutualFunds/{idMutualFund:int}")]
        [HttpGet]
        public MutualFund Get(int idMutualFund)
        {
            return crudService.Get(idMutualFund);
        }

        /// <summary>
        /// Updates the specified mutual fund.
        /// </summary>
        /// <param name="mutualFund">The mutual fund.</param>
        /// <returns></returns>
        [Route("MutualFunds")]
        [HttpPut]
        public MutualFund Update(MutualFund mutualFund)
        {
            return crudService.Update(mutualFund);
        }
    }
}
