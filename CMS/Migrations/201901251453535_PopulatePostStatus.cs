namespace CMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePostStatus : DbMigration
    {
        public override void Up()
        {
            Sql("insert into PostStatus (Description) values ('Published') ");
            Sql("insert into PostStatus (Description) values ('Draft') ");
            Sql("insert into PostStatus (Description) values ('Trash') ");
            Sql("insert into PostStatus (Description) values ('Pending') ");
        }
        
        public override void Down()
        {
        }
    }
}
