namespace MvcDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeFieldsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "EmailAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "EmailAddress", c => c.String());
            AlterColumn("dbo.Contacts", "Company", c => c.String());
            AlterColumn("dbo.Contacts", "Name", c => c.String());
        }
    }
}
