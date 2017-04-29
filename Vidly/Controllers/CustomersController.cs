using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose(); //disposing objects
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(), //It will Initialize to the default values which is interger and default value for interger is 0. 
                MembershipTypes = membershipTypes //MembershipTypes ViewModel = membeshipTypes collections.
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            //Add validations
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("CustomerForm", viewModel);
            }
            //check the if the customer has an Id otherwise it's a new customer
            if (customer.Id == 0)
                _context.Customers.Add(customer); //New customer
            else
            {
                //Update existing customer
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id); //fetch the customer id from the database

                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }

            _context.SaveChanges();  //It will generate sql statement base on the modification and run them in the database

            return RedirectToAction("Index", "Customers");
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); //Deffered execution not a sql query, to iterate the customers
            return View(customers);
        }

        public ActionResult Details(int Id)
        {

            //var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.MembershipTypeId == Id);

            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            //Initialize customer
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer, //get the specific customer
                MembershipTypes = _context.MembershipTypes.ToList() //list the MembershipTypes for iteration in the dropdown lists
            };

            return View("CustomerForm", viewModel);
        }

    }
}