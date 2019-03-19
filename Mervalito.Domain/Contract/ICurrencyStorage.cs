using Mervalito.Domain.Base;
using Mervalito.Model.Model;

namespace Mervalito.Domain.Contract
{
    public interface ICurrencyStorage : ICrudService<Currency, int>
    {
    }
}
