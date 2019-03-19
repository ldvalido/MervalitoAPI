using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class TitleTypeMapping : EntityTypeConfiguration<TitleType>
    {
        public TitleTypeMapping()
        {
            HasKey(t => t.Id).ToTable("TitleType");
            Property(t => t.Id).HasColumnName("IdTitleType");
            Property(t => t.Description).HasColumnName("Description");
        }
         
    }
}