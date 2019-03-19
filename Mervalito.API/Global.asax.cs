using System.Web;
using System.Web.Http;
using Autofac.Integration.WebApi;
using Mervalito.IOC;

namespace Mervalito.API
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.HttpApplication" />
    public class WebApiApplication : HttpApplication
    {
        /// <summary>
        /// Applications the start.
        /// </summary>
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var config = GlobalConfiguration.Configuration;
            var builder = new ServiceLocatorWebFluent().CreateContainer(config).Build();
            // Set the dependency resolver to be Autofac.
            config.DependencyResolver = new AutofacWebApiDependencyResolver(builder.GetRawContainer());
        }
    }
}
