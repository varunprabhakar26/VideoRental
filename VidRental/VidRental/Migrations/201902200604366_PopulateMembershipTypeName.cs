namespace VidRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            //Sql("UPDATE MembershipTypes (Name) VALUES('Pay as You Go') WHERE Id=1");
            //Sql("UPDATE MembershipTypes (Name) VALUES('Monthly') WHERE Id=2");
            //Sql("UPDATE MembershipTypes (Name) VALUES('Quarterly') WHERE Id=3");
            //Sql("UPDATE MembershipTypes (Name) VALUES('Half Yearly') WHERE Id=4");
            //Sql("UPDATE MembershipTypes (Name) VALUES('Annualy') WHERE Id=5");

            Sql("UPDATE MembershipTypes SET Name='Pay as You Go'  WHERE Id=1");
            Sql("UPDATE MembershipTypes SET Name='Monthly'  WHERE Id=2");
            Sql("UPDATE MembershipTypes SET Name='Quarterly'  WHERE Id=3");
            Sql("UPDATE MembershipTypes SET Name='Half Yearly'  WHERE Id=4");
            Sql("UPDATE MembershipTypes SET Name='Annualy'  WHERE Id=5");


        }
        
        public override void Down()
        {
        }
    }
}
