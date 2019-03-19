using Mervalito.Model.Model.Base;

namespace Mervalito.Model.Model
{
    public class Caution : BaseIdEntity
    {
        public Currency Currency { get; set; }
        public double Percentage { get; set; }
        public int Days { get; set; }
    }
}
