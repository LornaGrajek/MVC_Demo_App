namespace StoreApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (UserName, Password) VALUES ('Lorna', 'password')");
        }
        
        public override void Down()
        {
        }
    }
}
