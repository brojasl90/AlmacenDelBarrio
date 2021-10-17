using Infrastructure.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            log4net.Config.XmlConfigurator.Configure();
        }

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            CultureInfo oCulture = (CultureInfo) Thread.CurrentThread.CurrentCulture.Clone();
            oCulture.NumberFormat.NumberDecimalSeparator = ".";
            oCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            oCulture.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentUICulture = oCulture;
        }

        protected void Application_Error()
        {
            var ex = Server.GetLastError();
            Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod());
        }
    }
}