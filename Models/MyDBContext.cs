using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //This namespace is crucial for migrations

//go to Project on the top tool bar, Manage nuget packages, and search for EF Core (Entity Framework) and install
//go to Tools, nuget package manager, package manager console
//in the console, type enable-migrations to.... enable migrations
//to create a migration, type, add-migration <name-of-migration>
namespace StoreApp.Models
{
    public class MyDBContext:DbContext
    {
        public MyDBContext() { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}