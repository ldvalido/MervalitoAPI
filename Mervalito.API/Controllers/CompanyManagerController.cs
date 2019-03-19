using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Mervalito.Domain.Contract;
using Mervalito.Model.Model;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace Mervalito.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("")]

    public class CompanyManagerController : ApiController
    {
        /// <summary>
        /// Gets or sets the company manager service.
        /// </summary>
        /// <value>
        /// The company manager service.
        /// </value>
        ICompanyManagerService CompanyManagerService { get; set; }
        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [Route("companymanager")]
        [HttpGet]
        public List<CompanyManager> List()
        {
            return CompanyManagerService.List().ToList();
        }
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("companymanager/{id:int}")]
        public CompanyManager Get(int id)
        {
            return CompanyManagerService.Get(id);
        }
        /// <summary>
        /// Updates the specified companyManager identifier.
        /// </summary>
        /// <param name="companyManager">The companyManager.</param>
        /// <returns></returns>
        [Route("companymanager")]
        [HttpPut]
        public CompanyManager Update(CompanyManager companyManager)
        {
            return CompanyManagerService.Update(companyManager);
        }
        /// <summary>
        /// Creates the specified company manager.
        /// </summary>
        /// <param name="companyManager">The company manager.</param>
        /// <returns></returns>
        [Route("companymanager")]
        [HttpPost]
        public CompanyManager Create([FromBody]CompanyManager companyManager)
        {
            return CompanyManagerService.Create(companyManager);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyManagerService"></param>
        #region C...tor
        public CompanyManagerController(ICompanyManagerService companyManagerService)
        {
           CompanyManagerService = companyManagerService;
        }
        #endregion
    }
}
