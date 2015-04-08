namespace CFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameblogstabletonaplok : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Blogs", newName: "Naplok");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Naplok", newName: "Blogs");
        }
    }
}
