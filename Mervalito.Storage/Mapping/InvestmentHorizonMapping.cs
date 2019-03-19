using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class InvestmentHorizonMapping : EntityTypeConfiguration<InvestmentHorizon>
    {
        public InvestmentHorizonMapping()
        {

            HasKey(t => t.Id).ToTable("InvestmentHorizon");
            Property(t => t.Id).HasColumnName("IdInvestmentHorizon");
        }
    }
}
