using Mervalito.Model.Model.Base;

namespace Mervalito.Model.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BaseDescriptionEntity" />
    public class Currency : BaseDescriptionEntity
    {
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>
        /// The rate.
        /// </value>
        public float Rate { get; set; }
    }
}
