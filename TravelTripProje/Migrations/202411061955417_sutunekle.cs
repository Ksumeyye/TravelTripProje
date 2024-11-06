namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sutunekle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Baslik", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Baslik");
        }
    }
}
