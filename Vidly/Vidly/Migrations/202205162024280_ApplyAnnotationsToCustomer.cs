namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 26));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
        }
    }
}
