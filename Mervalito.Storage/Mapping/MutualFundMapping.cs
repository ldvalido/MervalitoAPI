using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class MutualFundMapping : EntityTypeConfiguration<MutualFund>
    {
        public MutualFundMapping()
        {
            HasKey(m => m.Id).ToTable("MutualFund");
            Property(m => m.Id).HasColumnName("IdMutualFund");
            Property(m => m.Description).HasColumnName("Name");

            HasRequired(t => t.Currency).WithMany().Map(p => p.MapKey("IdCurrency")).WillCascadeOnDelete(false);
            HasRequired(t => t.CompanyManager).WithMany().Map(p => p.MapKey("IdCompanyManager")).WillCascadeOnDelete(false);
            HasRequired(t => t.InvestmentHorizon).WithMany().Map(p => p.MapKey("IdInvestmentHorizon")).WillCascadeOnDelete(false);
        }
    }
}
