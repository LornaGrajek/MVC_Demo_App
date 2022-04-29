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

        private MyDBContext _context; //dependency injection
        public CustomerController()
        {
            _context = new MyDBContext(); //disposable object
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Users()
        {
            // var customers = GetCustomers(); we used this method when we were hardcoding our data

            //we are using dependency injection to retreive customer information from our dbcontext (database)
            // the dbcontext does not query the database, this is called deferred execution
            //the database gets queried when we iterate over the customers variable
            var customers = _context.Customers; 

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            //Single or default returns the only vaule in a sequence (list) that matches a parameter (id)
            //lamda expression, input parameter is 'c' for customer, the expression looks for customer id that matches id

            // using dependency injecton
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
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