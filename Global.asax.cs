using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleDotNetApp
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_Error()
        {
            // Handle application errors
        }

        protected void Session_Start()
        {
            // Session start logic
        }

        protected void Session_End()
        {
            // Session end logic
        }
    }

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
