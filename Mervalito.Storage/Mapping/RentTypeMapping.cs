using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class RentTypeMapping : EntityTypeConfiguration<RentType>
    {
        public RentTypeMapping()
        {
            HasKey(r => r.Id).ToTable("RentType");
            Property(r => r.Id).HasColumnName("IdRentType");
            Property(r => r.Description).HasColumnName("Description");
        }
    }
}
