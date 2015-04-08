namespace CFDemo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addaddressclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Address_Zip", c => c.Int(nullable: false));
            AddColumn("dbo.People", "Address_City", c => c.String());
            AddColumn("dbo.People", "Address_Street", c => c.String());
            AddColumn("dbo.People", "Address_Number", c => c.String());
            DropColumn("dbo.People", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Address", c => c.String());
            DropColumn("dbo.People", "Address_Number");
            DropColumn("dbo.People", "Address_Street");
            DropColumn("dbo.People", "Address_City");
            DropColumn("dbo.People", "Address_Zip");
        }
    }
}
