using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class PaymentPeriodMapping : EntityTypeConfiguration<PaymentPeriod>
    {
        public PaymentPeriodMapping()
        {
            HasKey(p => p.Id).ToTable("PaymentPeriod");
            Property(p => p.Id).HasColumnName("IdPaymentPeriod");
            Property(p => p.Description).HasColumnName("Description");
            Property(p => p.Days).HasColumnName("Days");
        }
    }
}
