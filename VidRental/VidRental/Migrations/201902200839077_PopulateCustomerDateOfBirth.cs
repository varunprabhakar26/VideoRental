namespace VidRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerDateOfBirth : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateOfBirth=1997/08/26 12:00:00 AM  WHERE Id=1");
            Sql("UPDATE Customers SET DateOfBirth=  WHERE Id=2");

        }
        
        public override void Down()
        {
        }
    }
}
