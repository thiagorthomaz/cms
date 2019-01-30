namespace CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePostFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "PostTitle", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.Posts", "PostContent", c => c.String(nullable: false));
            AddColumn("dbo.Posts", "PostSumary", c => c.String(maxLength: 1000));
            AddColumn("dbo.Posts", "PostSEO", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "PostSEO");
            DropColumn("dbo.Posts", "PostSumary");
            DropColumn("dbo.Posts", "PostContent");
            DropColumn("dbo.Posts", "PostTitle");
        }
    }
}
