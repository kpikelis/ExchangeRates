﻿using SEB.Web.Infrastructure;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SEB.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var dependencyRegistrar = new DependencyRegistrar();
            dependencyRegistrar.Configure();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
