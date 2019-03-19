using System.Collections.Generic;
using System.Web.Http;
using Mervalito.Domain.Contract;
using Mervalito.Model.Model;

namespace Mervalito.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("")]
    public class CautionController : ApiController
    {
        /// <summary>
        /// The caution service
        /// </summary>
        readonly ICautionService _cautionService;
        /// <summary>
        /// Initializes a new instance of the <see cref="CautionController"/> class.
        /// </summary>
        /// <param name="cautionService">The caution service.</param>
        public CautionController(ICautionService cautionService)
        {
            _cautionService = cautionService;
        }
        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [Route("caution")]
        [HttpGet]
        public IEnumerable<Caution> List()
        {
            return _cautionService.List();
        }
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [Route("caution/{id:int}")]
        [HttpGet]
        public Caution Get(int id)
        {
            return _cautionService.Get(id);
        }

        /// <summary>
        /// Creates the specified entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <returns></returns>
        [Route("caution")]
        [HttpPost]
        public Caution Create(Caution entry)
        {
            return _cautionService.Create(entry);
        }
        /// <summary>
        /// Updates the specified entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <returns></returns>
        [Route("caution")]
        [HttpPut]
        public Caution Update(Caution entry)
        {
            return _cautionService.Update(entry);
        }
        /// <summary>
        /// Deletes this instance.
        /// </summary>
        [Route("caution")]
        [HttpDelete]
        public void Delete(Caution entry)
        {
            _cautionService.Delete(entry);
        }

    }
}
