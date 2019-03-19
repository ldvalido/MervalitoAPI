using Mervalito.Domain.Base;
using Mervalito.Model.Model;
namespace Mervalito.Domain.Contract
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Mervalito.Domain.Base.ICrudService{Mervalito.Model.Model.Title}" />
    public interface ITitleService:ICrudService<Title,int>
    {
        bool UpdateRate();
    }
}
