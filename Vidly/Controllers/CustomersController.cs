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
        public ActionResult Index()
        {
            var customers = GetCustomer();
            return View(customers);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Nicanor Mallabo" },
                new Customer { Id = 2, Name = "Melarie Cortina" }
            };

            return customers;
        }

        public ActionResult Details(int Id)
        {

            var customer = GetCustomer().SingleOrDefault(c => c.Id == Id);

            return View(customer);
        }

    }
}