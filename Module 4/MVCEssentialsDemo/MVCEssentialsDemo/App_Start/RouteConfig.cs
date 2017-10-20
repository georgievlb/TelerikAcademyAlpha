using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCEssentialsDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}"); //which routes we can ignore// files with .axd come from Glimpse
                                                              //идеята е да ги игнорираме, за да може някой друг да ги handle-ва като напр. Glimpse
            routes.LowercaseUrls = true;

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",//паттерн който казва кои url matches този route
                //controller i action sa zapazeni dumi kato pravim route-ove
                //po default asp.net mvc e convention based framework
                //t.e. imeto na klasa, koito match-va kontrolera trqbva da zawyrshva na controller
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }// ако някой
                //не въведе някакви правилни стойности, стойностите по подразбиране се подават като defaults: 
                //контролера и action-а са две необходими неща, ако ги няма mvc-to не може да се оправи.
                //от тука може да ги комбинираме с някакви преконфигурирани routes. 
                //не може да имем два route-a с едно и също име. 
            );
        }
    }
}
