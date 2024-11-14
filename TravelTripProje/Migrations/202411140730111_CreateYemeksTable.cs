namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateYemeksTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yemeks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        YemekAdi = c.String(),
                        Aciklama = c.String(),
                        YemekImage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Yemeks");
        }
    }
}
