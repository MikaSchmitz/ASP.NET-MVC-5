namespace Vidly.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    
    public partial class SetGenres : DbMigration
    {
        List<string> genreNames = new List<string>() { "Action", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Thriller", "Western" };

        public override void Up()
        {
            foreach(string genreName in genreNames)
            {
                Sql($"INSERT INTO Genres (Name) VALUES ('{genreName}')");
            }
        }
        
        public override void Down()
        {
        }
    }
}
