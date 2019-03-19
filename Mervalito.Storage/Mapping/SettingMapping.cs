using System.Data.Entity.ModelConfiguration;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Mapping
{
    public class SettingMapping : EntityTypeConfiguration<Setting>
    {

        public SettingMapping()
        {
            HasKey(t => t.Id).ToTable("Setting");
            Property(t => t.Id).HasColumnName("IdSetting");
            Property(t => t.SettingName).HasColumnName("SettingName");
            Property(t => t.SettingValue).HasColumnName("SettingValue");
        }
    }
}
