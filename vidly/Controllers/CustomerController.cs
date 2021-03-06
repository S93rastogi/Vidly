﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer1 = new Customer()
            {
                Id = 1,
                Name = "Shubhanshu"
            };
            var customer2 = new Customer()
            {
                Id = 2,
                Name = "Kanica"
            };
            var registeredCustomers = new List<Customer>
            {
                customer1,
                customer2
            };
            var customers = new Customers()
            {
                RegisteredCustomers = registeredCustomers
            };
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            if (id == 1)
                return View("Details", new Customer() {Name = "shubhanshu"});
            else
                return View("Details", new Customer() {Name = "Kanica"});
        }
    }
}