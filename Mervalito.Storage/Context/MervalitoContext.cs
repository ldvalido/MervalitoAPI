using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using Mervalito.Model.Model;

namespace Mervalito.Storage.Context
{
    public class MervalitoContext :DbContext
    {
        #region Database Context
        public DbSet<BondType> BondTypes { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<PaymentPeriod> PaymentPeriod { get; set; }
        public DbSet<RentType> RentType { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<TitleType> TitleType { get; set; }
        public DbSet<InvestmentHorizon> InvestmentHorizon { get; set; }
        public DbSet<CompanyManager> CompanyManager { get; set; }
        public DbSet<MutualFund> MutualFund { get; set; }
        #endregion

        #region C...tor        
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanetaryMotionContext"/> class.
        /// </summary>
        public MervalitoContext() : base("MervalitoCnnStr")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MervalitoContext>());
            this.Configuration.LazyLoadingEnabled = true;
        }
        #endregion
        
        #region Overrides of DbContext
        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        ///             before the model has been locked down and used to initialize the context.  The default
        ///             implementation of this method does nothing, but it can be overridden in a derived class
        ///             such that the model can be further configured before it is locked down.
        /// </summary>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        ///             is created.  The model for that context is then cached and is for all further instances of
        ///             the context in the app domain.  This caching can be disabled by setting the ModelCaching
        ///             property on the given ModelBuidler, but note that this can seriously degrade performance.
        ///             More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        ///             classes directly.
        /// </remarks>
        /// <param name="modelBuilder">The builder that defines the model for the context being created. </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
