namespace DevExtremeMvcApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        ident = c.String(),
                        type = c.Int(nullable: false),
                        name = c.String(),
                        latitude_deg = c.Decimal(nullable: false, precision: 18, scale: 2),
                        longitude_deg = c.Decimal(nullable: false, precision: 18, scale: 2),
                        elevation_ft = c.Int(nullable: false),
                        continent = c.String(),
                        iso_country = c.String(),
                        iso_region = c.String(),
                        municipality = c.String(),
                        scheduled_service = c.Boolean(nullable: false),
                        gps_code = c.String(),
                        iata_code = c.String(),
                        local_code = c.String(),
                        keywords = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Airports");
        }
    }
}
