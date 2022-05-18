namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndUpdateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Shrek', 9);");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Hangover', 2);");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Die Hard', 1);");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Thermometer', 1);");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Titanic', 7);");
            Sql("INSERT INTO Movies (Name, GenreId) VALUES ('Zeebats', 3);");
        }
        
        public override void Down()
        {
        }
    }
}
