using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreApp.Models;
using StoreApp.ViewModels; //Dont forget to include your namespaces

namespace StoreApp.Controllers
{
    public class StoreController : Controller
    {
        private MyDBContext _context; //dependency injection,  by convention all private fields are < _name > lowercase, prefixed with an underscore
        public StoreController()
        {
            _context = new MyDBContext(); //disposable object
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Store
        public ActionResult Locations()
        {
            var stores = new List<Store>
            {
                new Store { Id = 1, Name = "Area 51", Address = "Earth" },
                new Store { Id = 2, Name = "Colony A", Address = "Alpha Centauri" }
            };

            var products = new List<Products>
            {
                new Products {Id = 1, Name = "Phaser", Description = "Set it to stun!", Price = 99, StoreId = 1},
                new Products {Id = 2, Name = "Abduction Beam", Description = "Comes in 3 sizes: Cow, Car, Human", Price = 500, StoreId = 2},
                new Products {Id = 3, Name = "Exam Table", Description = "For examining specimens", Price = 50, StoreId = 2}
            };

            var viewModel = new StoreProductsViewModel { Stores = stores, Products = products };

            return View(viewModel);
        }

        public ActionResult New()
        {
            var store = new Store();  
            
            return View(store);
        }

        [HttpPost] //any action that is not getting data, should be labeled as such 
        public ActionResult Create(Store store) //modelbinding: the new action returns the model store, and we want to bind our input to this model. so this action takes the parameter of the model from the previous action
        {
            _context.Stores.Add(store);
            _context.SaveChanges(); //this method will add any changes to the dbcontext, update the models, and then generate and run sql statements at the runtime
            return RedirectToAction("Index", "Store"); //redirects you to another page, "Action", "controller" , can be any action or controller
        }
    }
}