using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    public class SettingController : ApiController
    {
        /// <summary>
        /// The setting service
        /// </summary>
        private readonly ISettingService _settingService;

        /// <summary>
        /// Lists this instance.
        /// </summary>
        /// <returns></returns>
        [Route("settings")]
        [HttpGet]
        
        public IEnumerable<Setting> List()
        {
            return _settingService.List();
        }
        /// <summary>
        /// Gets the specified identifier setting.
        /// </summary>
        /// <param name="idSetting">The identifier setting.</param>
        [Route("setting/{idSetting:int}")]
        [HttpGet]
        public Setting Get(int idSetting)
        {
            return _settingService.Get(idSetting);
        }
        /// <summary>
        /// Gets the name of the by setting.
        /// </summary>
        /// <param name="settingName">Name of the setting.</param>
        /// <returns></returns>
        [Route("setting/{settingName}")]
        [HttpGet]
        public Setting GetBySettingName(string settingName)
        {
            return
                _settingService.GetBy(
                    setting =>
                        string.Compare(setting.SettingName, settingName, StringComparison.InvariantCultureIgnoreCase) ==
                        0);
        }
        /// <summary>
        /// Creates the specified setting.
        /// </summary>
        /// <param name="setting">The setting.</param>
        /// <returns></returns>
        [Route("setting")]
        [HttpPost]
        public Setting Create(Setting setting)
        {
            return _settingService.Create(setting);
        }
        /// <summary>
        /// Updates the specified setting.
        /// </summary>
        /// <param name="setting">The setting.</param>
        /// <returns></returns>
        [Route("setting")]
        [HttpPut]
        public Setting Update(Setting setting)
        {
            return _settingService.Update(setting);
        }
        /// <summary>
        /// Deletes the specified setting.
        /// </summary>
        /// <param name="setting">The setting.</param>
        [Route("setting")]
        [HttpDelete]
        public void Delete(Setting setting)
        {
            _settingService.Delete(setting);
        }
        #region C...tor        
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingController"/> class.
        /// </summary>
        /// <param name="settingService">The setting service.</param>
        public SettingController(ISettingService settingService)
        {
            _settingService = settingService;
        }
        #endregion
    }
}
