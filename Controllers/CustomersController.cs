﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        [Route("Customers")]
        public IActionResult Index()
        {
            var customers = new List<Customer> {
                                new Customer { Name = "customer1" },
                                new Customer { Name = "customer2" }
            };
            return View(customers);
        }
    }
}

