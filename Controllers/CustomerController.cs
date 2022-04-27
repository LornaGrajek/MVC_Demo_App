using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreApp.Models;


namespace StoreApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Users()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            //Single or default returns the only vaule in a sequence (list) that matches a parameter (id)
            //lamda expression, input parameter is 'c' for customer, the expression looks for customer id that matches id

            if(customer == null)
                return HttpNotFound();

            return View(customer);
        }


        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1 , UserName = "Lorna"},
                new Customer { Id = 2 , UserName = "Victoria"},
                new Customer { Id = 3 , UserName = "Daisy"}
            };
        }

    }
}