namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayToUsers2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            Sql("UPDATE Customers SET Birthdate = 2001-07-16 WHERE Id = 1;");
            Sql("UPDATE Customers SET Birthdate = NULL WHERE Id = 2;");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
