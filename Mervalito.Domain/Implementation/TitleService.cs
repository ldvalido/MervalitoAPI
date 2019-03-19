using System.Linq;
using Mervalito.Domain.Base;
using Mervalito.Domain.Contract;
using Mervalito.Model.Model;
using Mervalito.Storage.Base;
using RestSharp;

namespace Mervalito.Domain.Implementation
{
    public class TitleService : CrudService<Title,int>,ITitleService
    {
        public IStorageBase<Setting,int> SettingStorage { get; set; }

        #region Implementation of ITitleService        
        /// <summary>
        /// Updates the rate.
        /// </summary>
        /// <returns></returns>
        public bool UpdateRate()
        {
            var setting = SettingStorage.GetByCriteria(f => f.SettingName == DomainConst.ProxySmartModuleUrl).First();
            
            var client = new RestClient(setting.SettingValue);
            var request = new RestRequest("updateBond");
            client.Execute(request);
            return true;
        }

        #endregion
    }
}
