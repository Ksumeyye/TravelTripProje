namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKampsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kamps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KampAdi = c.String(),
                        Aciklama = c.String(),
                        KampImage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kamps");
        }
    }
}
