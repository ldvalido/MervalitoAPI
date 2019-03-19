using System;
using Mervalito.Model.Model.Base;

namespace Mervalito.Model.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BaseDescriptionEntity" />
    public class Title :BaseDescriptionEntity
    {
        /// <summary>
        /// Gets or sets the amortization date.
        /// </summary>
        /// <value>
        /// The amortization date.
        /// </value>
        public DateTime AmortizationDate { get; set; }
        /// <summary>
        /// Gets or sets the amortization amount.
        /// </summary>
        /// <value>
        /// The amortization amount.
        /// </value>
        public double AmortizationAmount { get; set; }
        /// <summary>
        /// Gets or sets the rent date.
        /// </summary>
        /// <value>
        /// The rent date.
        /// </value>
        public DateTime RentDate { get; set; }
        /// <summary>
        /// Gets or sets the rent amount.
        /// </summary>
        /// <value>
        /// The rent amount.
        /// </value>
        public double RentAmount { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the minimum quantity.
        /// </summary>
        /// <value>
        /// The minimum quantity.
        /// </value>
        public int MinimumQuantity { get; set; }
        /// <summary>
        /// Gets or sets the tir.
        /// </summary>
        /// <value>
        /// The tir.
        /// </value>
        public double TIR { get; set; }
        /// <summary>
        /// Gets or sets the payment period.
        /// </summary>
        /// <value>
        /// The payment period.
        /// </value>
        public PaymentPeriod PaymentPeriod{get;set;}
        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        public Currency Currency { get; set; }
        /// <summary>
        /// Gets or sets the type of the title.
        /// </summary>
        /// <value>
        /// The type of the title.
        /// </value>
        public TitleType TitleType{get;set;}
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get; set; }
        /// <summary>
        /// Gets or sets the type of the bond.
        /// </summary>
        /// <value>
        /// The type of the bond.
        /// </value>
        public BondType BondType { get; set; }
        /// <summary>
        /// Gets or sets the type of the rent.
        /// </summary>
        /// <value>
        /// The type of the rent.
        /// </value>
        public RentType RentType { get; set; }

    }
}
