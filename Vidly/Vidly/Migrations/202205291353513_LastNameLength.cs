namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastNameLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false));
        }
    }
}
