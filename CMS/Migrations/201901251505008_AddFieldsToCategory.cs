namespace CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldsToCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Description", c => c.String(nullable: false));
            AddColumn("dbo.Categories", "Slug", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Slug");
            DropColumn("dbo.Categories", "Description");
        }
    }
}
