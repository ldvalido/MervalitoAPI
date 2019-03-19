using Mervalito.Model.Model.Base;

namespace Mervalito.Model.Model
{
    public class Setting : BaseIdEntity
    {
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
    }
}
