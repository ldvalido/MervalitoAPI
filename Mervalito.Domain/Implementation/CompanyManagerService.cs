using Mervalito.Domain.Base;
using Mervalito.Domain.Contract;
using Mervalito.Model.Model;

namespace Mervalito.Domain.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Mervalito.Domain.Contract.ICompanyManagerService" />
    public class CompanyManagerService :  CrudService<CompanyManager, int>,ICompanyManagerService
    {
    }
}
