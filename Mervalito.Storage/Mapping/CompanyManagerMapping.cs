using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class CompanyManagerMapping : EntityTypeConfiguration<CompanyManager>
    {
        public CompanyManagerMapping()
        {
            HasKey(t => t.Id).ToTable("CompanyManager");
            Property(t => t.Id).HasColumnName("IdCompanyManager");
        }
    }
}
