namespace MGsTok.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IlIlceAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ils",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sehir = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ilcelers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ilce = c.String(),
                        sehir = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ilcelers");
            DropTable("dbo.Ils");
        }
    }
}
