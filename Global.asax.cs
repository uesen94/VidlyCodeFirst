using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using VidlyCF.App_Start;

namespace VidlyCF
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            Mapper.Initialize(c=>c.AddProfile<MappingProfile>());
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
