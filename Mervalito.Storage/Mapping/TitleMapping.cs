using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class TitleMapping : EntityTypeConfiguration<Title>
    {
        public TitleMapping()
        {
            HasKey(t => t.Id).ToTable("Title");
            Property(t => t.Id).HasColumnName("IdTitle");
            Property(t => t.Description).HasColumnName("Name");
            Property(t => t.AmortizationAmount).HasColumnName("AmortizationAmmount");
            Property(t => t.RentAmount).HasColumnName("RentAmmount");
            Property(t => t.MinimumQuantity).HasColumnName("MinimumQuantity");

            HasRequired(t => t.PaymentPeriod).WithMany().Map(p => p.MapKey("IdPaymentPeriod")).WillCascadeOnDelete(false);
            HasRequired(t => t.BondType).WithMany().Map(p => p.MapKey("IdbondType")).WillCascadeOnDelete(false);
            HasRequired(t => t.Currency).WithMany().Map(p => p.MapKey("IdCurrency")).WillCascadeOnDelete(false);
            HasRequired(t => t.TitleType).WithMany().Map(p => p.MapKey("IdTitleType")).WillCascadeOnDelete(false);
            HasRequired(t => t.RentType).WithMany().Map(p => p.MapKey("IdRentType")).WillCascadeOnDelete(false);

        }
    }
}
