namespace CFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addpersontableidtoblogtable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Blogs", "Blogger_Id", "dbo.People");
            DropIndex("dbo.Blogs", new[] { "Blogger_Id" });
            RenameColumn(table: "dbo.Blogs", name: "Blogger_Id", newName: "BloggerId");
            AlterColumn("dbo.Blogs", "BloggerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Blogs", "BloggerId");
            AddForeignKey("dbo.Blogs", "BloggerId", "dbo.People", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "BloggerId", "dbo.People");
            DropIndex("dbo.Blogs", new[] { "BloggerId" });
            AlterColumn("dbo.Blogs", "BloggerId", c => c.Int());
            RenameColumn(table: "dbo.Blogs", name: "BloggerId", newName: "Blogger_Id");
            CreateIndex("dbo.Blogs", "Blogger_Id");
            AddForeignKey("dbo.Blogs", "Blogger_Id", "dbo.People", "Id");
        }
    }
}
