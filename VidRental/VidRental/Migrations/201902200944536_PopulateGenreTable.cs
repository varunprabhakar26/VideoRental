namespace VidRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(GenreName) VALUES('Action')");
            Sql("INSERT INTO Genres(GenreName) VALUES('Comedy')");
            Sql("INSERT INTO Genres(GenreName) VALUES('Romance')");

        }
        
        public override void Down()
        {
        }
    }
}
