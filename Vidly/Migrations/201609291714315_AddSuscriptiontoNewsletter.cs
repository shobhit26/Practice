namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSuscriptiontoNewsletter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "SuscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "SuscribedToNewsletter");
        }
    }
}
