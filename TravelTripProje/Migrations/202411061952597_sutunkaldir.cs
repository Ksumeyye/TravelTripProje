namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sutunkaldir : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Blogs", "Baslik");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "Baslik", c => c.Int(nullable: false));
        }
    }
}
