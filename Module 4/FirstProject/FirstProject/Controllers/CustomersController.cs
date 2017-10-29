using FirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstProject.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("customers")]
        public ViewResult Index()
        {
            var customersList = GetCustomers();

            return this.View(customersList);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            
            return View(customer);

        }


    }
}