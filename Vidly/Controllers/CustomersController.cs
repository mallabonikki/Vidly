﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

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

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); //Deffered execution not a sql query, to iterate the customers
            return View(customers);
        }

        public ActionResult Details(int Id)
        {

            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);

            return View(customer);
        }

    }
}