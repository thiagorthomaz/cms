namespace CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategory : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categories (Description, Slug, CreatedAt) values ('Undefined', 'undefined', GETDATE())");
        }
        
        public override void Down()
        {
        }
    }
}
