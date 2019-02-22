namespace VidRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerDateOfBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
