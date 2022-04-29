using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models
{
    public class Products
    {
        public int Id { get; set; }
        //[Display(Name = "Store Location")] this property will display the preferred name in a form label if you don't want this model property displayed instead
        public int StoreId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}