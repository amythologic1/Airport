namespace DevExtremeMvcApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arprt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Airports", "home_link", c => c.String());
            AddColumn("dbo.Airports", "wikipedia_link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Airports", "wikipedia_link");
            DropColumn("dbo.Airports", "home_link");
        }
    }
}
