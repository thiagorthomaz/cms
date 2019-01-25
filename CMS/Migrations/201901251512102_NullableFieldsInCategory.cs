namespace CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableFieldsInCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.Categories", "DeletedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "DeletedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Categories", "UpdatedAt", c => c.DateTime(nullable: false));
        }
    }
}
