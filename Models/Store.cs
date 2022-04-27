using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models
{
    public class Store
    {
        public int Id { get; set; }
        [Required] //Data Annotations tell EF Core what conventions to put in your database. Required, this column can not be null
        [StringLength(100)] //sets the max length NVARCHAR in SQL database
        public string Name { get; set; }
        public string Address { get; set; }

    }
}