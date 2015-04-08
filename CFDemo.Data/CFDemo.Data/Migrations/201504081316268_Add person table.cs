namespace CFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addpersontable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Blogs", "Blogger_Id", c => c.Int());
            CreateIndex("dbo.Blogs", "Blogger_Id");
            AddForeignKey("dbo.Blogs", "Blogger_Id", "dbo.People", "Id");
            DropColumn("dbo.Blogs", "BloggerName");
            DropColumn("dbo.Blogs", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "Address", c => c.String());
            AddColumn("dbo.Blogs", "BloggerName", c => c.String());
            DropForeignKey("dbo.Blogs", "Blogger_Id", "dbo.People");
            DropIndex("dbo.Blogs", new[] { "Blogger_Id" });
            DropColumn("dbo.Blogs", "Blogger_Id");
            DropTable("dbo.People");
        }
    }
}
