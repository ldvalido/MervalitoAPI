using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class CurrencyMapping : EntityTypeConfiguration<Currency>
    {
        public CurrencyMapping()
        {
            HasKey(c => c.Id).ToTable("Currency");
            Property(t => t.Id).HasColumnName("IdCurrency");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.Symbol).HasColumnName("Symbol");
            Property(t => t.Rate).HasColumnName("Rate").HasColumnType("float");
        }
    }
}
