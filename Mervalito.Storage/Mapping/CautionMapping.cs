using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Data.Entity.ModelConfiguration.EntityTypeConfiguration{Caution}" />
    public class CautionMapping : EntityTypeConfiguration<Caution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CautionMapping"/> class.
        /// </summary>
        public CautionMapping()
        {
            HasKey(c => c.Id).ToTable("Caution");
            Property(c => c.Id).HasColumnName("IdCaution");
            Property(c => c.Days).HasColumnName("Days");
            Property(c => c.Percentage).HasColumnName("Percentage");

            HasRequired(t => t.Currency).WithMany().Map(p => p.MapKey("IdCurrency")).WillCascadeOnDelete(false);
        }
    }
}
