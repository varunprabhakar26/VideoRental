namespace VidRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(SignUpFee,DurationInMonths,DiscoutRate) VALUES(0,0,0)");
            Sql("INSERT INTO MembershipTypes(SignUpFee,DurationInMonths,DiscoutRate) VALUES(100,1,10)");
            Sql("INSERT INTO MembershipTypes(SignUpFee,DurationInMonths,DiscoutRate) VALUES(200,3,20)");
            Sql("INSERT INTO MembershipTypes(SignUpFee,DurationInMonths,DiscoutRate) VALUES(300,6,30)");
            Sql("INSERT INTO MembershipTypes(SignUpFee,DurationInMonths,DiscoutRate) VALUES(400,12,40)");
        }
        
        public override void Down()
        {
        }
    }
}
