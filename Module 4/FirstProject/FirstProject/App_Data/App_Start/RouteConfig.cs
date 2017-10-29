using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;    //one of the first things to add when starting a new project

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();     //Alternatively, we can use Attribute Routing instead of routes.MapRoute()


            /*
            routes.MapRoute(//start with most specific route and end with most generic route; they must also be convention-based
                "MoviesByReleaseDate", //first parameter of the custom route is its name
                "movies/released/{year}/{month}",//second parameter is the URL pattern
                 new { controller = "Movies", action = "ByReleaseDate"},//third parameter is to specify defaults
            //(we use an anonymous object for that - it includes the name of the controller as well as the name of the action)
            //after that, we need to create that action (in this case the action is "ByReleaseDate" -
            //we do that in the MoviesController

            //in order to create year and month constraints, we need to supply another argument to our MapRoute() method
            //by using an anonymous object where we can use RegEx to apply constraints
                 new { year = @"\d{4}", month = @"\d{2}"}
                 );

            */

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",//default parameter name is called id
                                                  //the value that we pass here is going to be
                                                  //identified as id NOT movieId or anything else
                                                  //this is how ASP.NET maps request data to parameters over actions -
                                                  //it uses strict naming
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }//ако някой не въведе котролер, ще ползваме home,
                                                                                                    //ако не въведе action ще ползваме index, 
                                                                                                    //ако не въведем id, то си е optional
            );
        }
    }
}
