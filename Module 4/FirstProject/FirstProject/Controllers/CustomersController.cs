using FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using FirstProject.ViewModels;

namespace FirstProject.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext context;

        public CustomersController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose (bool disposing)
        {
            context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }

        
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        // GET: Customers
        //[Route("customers")]
        public ViewResult Index()
        {
            var customersList = context.Customers.Include(c => c.MembershipType).ToList();  //EF is not gonna query the DB when this line is executed. This is called Deffered Execution
            //the query is executed when we iterate over the customers object
            //if for example we type .ToList(), the query is going to be immediately executed

            //when we use .Include we tell EF to load the object, with its related objects. This is called eager loading.

            return this.View(customersList);
        }

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //[Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id); //query will be immediately executed because of singleOrDefault extension method

            if (customer == null)
            {
                return HttpNotFound();
            }
            
            return View(customer);
        }


    }
}