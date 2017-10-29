using FirstProject.Models;
using FirstProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class MoviesController : Controller
    {
        [Route("movies")]
        public ActionResult Index()
        {
            return this.View();
        }

        // GET: /Movies/Random
        public ViewResult Random() //will be called when we go to /movies/random
                                   //Our random() action returns an action result. This action result is the base class
                                   //for all action results in ASP.NET MVC. Depending on what an action does, it will
                                   //return an instance of one of the classses that derive from action result.

        //In our random action, we are calling the view method here, which is just a helper method,
        //inherited from the base class: Controller. This method allows us to quickly create a view result.
        //Alternatively, we can return a new ViewResult(); But it is easier to just call the view method
        //and this approach is way more common among ASP.NET MVC devs.

        //Why is the return type of this method ActionResult(), even though we are actually returning a view result?
        //In our case we can set the return type to ViewResult instead of ActionResult and this is 
        //actually good practice to change ActionResult to ViewResult because helps with unit testing
        //by saving us from an extra cast in our Unit Tests.

        //Sometimes it is possible in an action to have different execution paths and return different
        //action results. In such cases we need to set the return type of that action to ActionResult, so that we can return
        //any of its subtypes. 

        //ViewResult() is one of the ActionResults that you work with most of the time. 
        //Other types of ActionResults are:
        //RedirectResult(); HttpNotFoundResult(); etc.. For the most part we will be using View(); HttpNotFound() and Redirect();
        {
            Movie movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer{ Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //ViewData["Movie"] = movie; //every controller has a property called ViewData, which is of type ViewDataDictionary

            return View(viewModel); //View() method is inherited from the Controller class. 
                                //It is just a helper method.

            //action results are the output of our actions()
            //action parameters are the inputs of our actions()

            //ASP.NET maps request data to parameters over actions
            //we can also have optional parameters in our actions.
            //string type in C# is a reference type and it's nullable


        }

        /*

        public ActionResult Edit(int id)
        {
            return Content($"id={id}");
        }

        //example of an optional parameter inside an ActionResult
        //this controller will be used when we navigate to /movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //if pageIndex is not specified, we display the movies in page 1
            //similarly, if sortBy is not specified, we sort the movies by their name

            //inside this action we must check to see if the parameters have any value 
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if(String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");//returns a content for demo purposes 
            //return a view with a list of movies in the database

            //in this case we cannot embed these parameters(pageIndex and sortBy) in the URL,
            //because that would require a custom route that includes two parameters
        }


        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year} / {month}");//we can apply constraints to our routes (this happens in RouteConfig)
        }


    */
    }
}