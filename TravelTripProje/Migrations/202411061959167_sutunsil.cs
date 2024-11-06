namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sutunsil : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Blogs", "Tarih");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "Tarih", c => c.DateTime(nullable: false));
        }
    }
}
