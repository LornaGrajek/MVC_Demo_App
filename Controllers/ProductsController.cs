using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        [Route("products/bystore/{id}")] //custom route will display products based off the input parameter, which will be passed as storeId
        public ActionResult ProductByStoreId(int id)
        {

            var products = new List<Products>
            {
                new Products {Id = 1, Name = "Phaser", Description = "Set it to stun!", Price = 99, StoreId = 1},
                new Products {Id = 2, Name = "Abduction Beam", Description = "Comes in 3 sizes: Cow, Car, Human", Price = 500, StoreId = 2},
                new Products {Id = 3, Name = "Exam Table", Description = "For examining specimens", Price = 50, StoreId = 2}
            };

            var currentProducts = new List<Products>(); //empty list

            foreach(var product in products) //loop through product list, if the storeId matches the input Id, add that product to the empty list
                if(product.StoreId == id)
                    currentProducts.Add(product);

            return View(currentProducts); //pass the second list as a model into the view
                    
        }
    }
}