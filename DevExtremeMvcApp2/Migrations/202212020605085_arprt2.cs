namespace DevExtremeMvcApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class arprt2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Airports", "elevation_ft", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Airports", "elevation_ft", c => c.Int(nullable: false));
        }
    }
}
