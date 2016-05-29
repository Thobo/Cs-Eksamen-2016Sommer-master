namespace Formel1.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTablesToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverId = c.Int(nullable: false, identity: true),
                        DriverName = c.String(),
                        Age = c.Int(nullable: false),
                        Country = c.String(),
                        TeamId = c.Int(nullable: false),
                        Driver_DriverId = c.Int(),
                    })
                .PrimaryKey(t => t.DriverId)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverId)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.Driver_DriverId);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RaceName = c.String(),
                        Country = c.String(),
                        Date = c.DateTime(nullable: false),
                        CircuitLength = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Filename = c.String(),
                        Race_Id = c.Int(),
                        Result_ResultId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.Race_Id)
                .ForeignKey("dbo.Results", t => t.Result_ResultId)
                .Index(t => t.Race_Id)
                .Index(t => t.Result_ResultId);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        ResultId = c.Int(nullable: false, identity: true),
                        DriverId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        RaceTime = c.DateTime(nullable: false),
                        Point = c.Int(nullable: false),
                        PlusLabs = c.Int(nullable: false),
                        RaceId = c.Int(nullable: false),
                        DNF = c.String(),
                    })
                .PrimaryKey(t => t.ResultId);
            
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        SeasonId = c.Int(nullable: false, identity: true),
                        Year = c.DateTime(nullable: false),
                        RaceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SeasonId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        EngineSupplier = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drivers", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Races", "Result_ResultId", "dbo.Results");
            DropForeignKey("dbo.Races", "Race_Id", "dbo.Races");
            DropForeignKey("dbo.Drivers", "Driver_DriverId", "dbo.Drivers");
            DropIndex("dbo.Races", new[] { "Result_ResultId" });
            DropIndex("dbo.Races", new[] { "Race_Id" });
            DropIndex("dbo.Drivers", new[] { "Driver_DriverId" });
            DropIndex("dbo.Drivers", new[] { "TeamId" });
            DropTable("dbo.Teams");
            DropTable("dbo.Seasons");
            DropTable("dbo.Results");
            DropTable("dbo.Races");
            DropTable("dbo.Drivers");
        }
    }
}
