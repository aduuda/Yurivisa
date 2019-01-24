using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace YuriVisa
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "foreigner",
                url: "vietnam-visa-services-for-foreigner",
                defaults: new { controller = "Home", action = "foreigner", id = UrlParameter.Optional }
            );
  
            routes.MapRoute(
                name: "issuance",
                url: "vietnam-visa-services-for-foreigner/issuance-of-vietnam-visa",
                defaults: new { controller = "Home", action = "issuance", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "extension",
               url: "vietnam-visa-services-for-foreigner/extension-and-renewal-of-vietnam-visa",
               defaults: new { controller = "Home", action = "extension", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "apply",
               url: "vietnam-visa-services-for-foreigner/apply-for-an-approval-letter-to-enter-vietnam",
               defaults: new { controller = "Home", action = "apply", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "temporary",
               url: "vietnam-visa-services-for-foreigner/temporary-residence-card",
               defaults: new { controller = "Home", action = "temporary", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "TouristVisa",
               url: "vietnam-visa-services-for-vietnamese/tourist-visa",
               defaults: new { controller = "Home", action = "TouristVisa", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "ForVietnamese",
              url: "vietnam-visa-services-for-vietnamese",
              defaults: new { controller = "Home", action = "ForVietnamese", id = UrlParameter.Optional }
          );
            routes.MapRoute(
               name: "about",
               url: "about-us",
               defaults: new { controller = "Home", action = "about", id = UrlParameter.Optional }
           );
            routes.MapRoute(
              name: "payment",
              url: "payment-infomation",
              defaults: new { controller = "Home", action = "payment", id = UrlParameter.Optional }
          );
            routes.MapRoute(
              name: "home",
              url: "home",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
