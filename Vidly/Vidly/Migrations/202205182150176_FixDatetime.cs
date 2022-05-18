namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDatetime : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('2001-07-16' AS DATETIME) WHERE Id = 1;");
        }
        
        public override void Down()
        {
        }
    }
}
