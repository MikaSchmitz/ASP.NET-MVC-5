namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredFields : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = CAST('2001-07-12' AS DATETIME), AddedDate = CAST('2022-05-19' AS DATETIME), NumberInStock = 420 WHERE Id = 2;");
            Sql("UPDATE Movies SET ReleaseDate = CAST('2005-05-10' AS DATETIME), AddedDate = CAST('2022-05-19' AS DATETIME), NumberInStock = 5 WHERE Id = 3;");
            Sql("UPDATE Movies SET ReleaseDate = CAST('2004-12-21' AS DATETIME), AddedDate = CAST('2022-05-19' AS DATETIME), NumberInStock = 6 WHERE Id = 4;");
            Sql("UPDATE Movies SET ReleaseDate = CAST('2006-10-25' AS DATETIME), AddedDate = CAST('2022-05-19' AS DATETIME), NumberInStock = 12 WHERE Id = 5;");
            Sql("UPDATE Movies SET ReleaseDate = CAST('2002-03-16' AS DATETIME), AddedDate = CAST('2022-05-19' AS DATETIME), NumberInStock = 2 WHERE Id = 6;");
            Sql("UPDATE Movies SET ReleaseDate = CAST('2005-02-05' AS DATETIME), AddedDate = CAST('2022-05-19' AS DATETIME), NumberInStock = 1 WHERE Id = 7;");
        }
        
        public override void Down()
        {
        }
    }
}
