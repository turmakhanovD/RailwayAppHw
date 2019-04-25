namespace RailwayApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Path", c => c.String());
            AddColumn("dbo.Trains", "TrainName", c => c.String());
            AddColumn("dbo.Trains", "CarriageCount", c => c.Int(nullable: false));
            DropColumn("dbo.Tickets", "FromCity");
            DropColumn("dbo.Tickets", "ToCity");
            DropColumn("dbo.Tickets", "TypeOfPlace");
            DropColumn("dbo.Trains", "Name");
            DropColumn("dbo.Trains", "CarriageSum");
            DropColumn("dbo.Trains", "CreatedTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trains", "CreatedTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Trains", "CarriageSum", c => c.Int(nullable: false));
            AddColumn("dbo.Trains", "Name", c => c.String());
            AddColumn("dbo.Tickets", "TypeOfPlace", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "ToCity", c => c.String());
            AddColumn("dbo.Tickets", "FromCity", c => c.String());
            DropColumn("dbo.Trains", "CarriageCount");
            DropColumn("dbo.Trains", "TrainName");
            DropColumn("dbo.Tickets", "Path");
        }
    }
}
