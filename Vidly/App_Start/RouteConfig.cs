using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    // configurations of the routing rules
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Custom route, shoud be created before the default route
            //Object Contraits could only be work on embeded url
            routes.MapRoute(
              "MoviesByReleaseDate",
              "movies/released/{year}/{month}",
              // use this to obtain the query string url //url: "{controller}/{action}/{year}/{month}",
              new { Controller = "Movies", Action = "ByReleaseDate"  },
              //new { year = @"\d{4}", month = @"\d{2}" }
              new { year = @"2015|2016", month = @"\d{2}" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
