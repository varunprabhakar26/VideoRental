namespace VidRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerDateOfBirth1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime());
        }
    }
}
