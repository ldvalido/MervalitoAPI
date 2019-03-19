using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class BondTypeMapping : EntityTypeConfiguration<BondType>
    {
        public BondTypeMapping()
        {
            HasKey(t => t.Id).ToTable("BondType");
            Property(t => t.Id).HasColumnName("IdBondType");
            Property(t => t.Description).HasColumnName("Description");
        }
    }
}
