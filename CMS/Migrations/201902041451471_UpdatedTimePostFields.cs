namespace CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTimePostFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "UpdatedAt", c => c.DateTime());
            AlterColumn("dbo.Posts", "DeletedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "DeletedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posts", "UpdatedAt", c => c.DateTime(nullable: false));
        }
    }
}
