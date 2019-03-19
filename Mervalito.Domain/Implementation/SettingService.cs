using Mervalito.Domain.Base;
using Mervalito.Domain.Contract;
using Mervalito.Model.Model;

namespace Mervalito.Domain.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Mervalito.Domain.Base.CrudService{Mervalito.Model.Model.Setting, System.Int32}" />
    /// <seealso cref="Mervalito.Domain.Contract.ISettingService" />
    public class SettingService : CrudService<Setting, int>, ISettingService
    {
    }
}
