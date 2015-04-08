namespace CFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Titletypeinttostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Title", c => c.String());
            //Sql("insert into Blogs () values ()");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Title");
            AddColumn("dbo.Blogs", "Title", c => c.Int(nullable: true));
            //AlterColumn("dbo.Blogs", "Title", c => c.Int(nullable: false));
        }
    }
}
