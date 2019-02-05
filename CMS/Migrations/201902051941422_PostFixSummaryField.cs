namespace CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostFixSummaryField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "PostSummary", c => c.String(maxLength: 1000));
            DropColumn("dbo.Posts", "PostSumary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "PostSumary", c => c.String(maxLength: 1000));
            DropColumn("dbo.Posts", "PostSummary");
        }
    }
}
