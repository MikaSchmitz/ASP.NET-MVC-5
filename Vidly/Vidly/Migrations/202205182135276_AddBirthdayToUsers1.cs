namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = 2001-07-16 WHERE Id = 1;");
        }
        
        public override void Down()
        {
        }
    }
}
