namespace CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryAddName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Name");
        }
    }
}
