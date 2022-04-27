using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StoreApp.Models;

namespace StoreApp.ViewModels
{
    public class StoreProductsViewModel
    {
        public List<Store> Stores { get; set; }
        public List<Products> Products { get; set; }

    }
}