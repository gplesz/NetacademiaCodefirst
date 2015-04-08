namespace CFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameBlogIdtoAzonosito : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Naplok", name: "Id", newName: "Azonosito");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Naplok", name: "Azonosito", newName: "Id");
        }
    }
}
