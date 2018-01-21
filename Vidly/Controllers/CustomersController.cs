using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View();
        }

        public ActionResult Details(int id)
        { 
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            //var customer = (from cust in GetCustomers() where cust.Id == id select cust).SingleOrDefault();
            //SingleOrDefault => "Returns the only element of a sequence, or a default value if the sequence is empty; "

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Baskoro Nugroho"},
                new Customer {Id = 2, Name = "Son Goku"}
            };
        }

    }

}