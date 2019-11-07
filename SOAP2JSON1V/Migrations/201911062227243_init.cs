namespace SOAP2JSON1V.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.D1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        INSERT_DATE = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.D2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        D1Id = c.Int(nullable: false),
                        INSERT_DATE = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.D1", t => t.D1Id, cascadeDelete: true)
                .Index(t => t.D1Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.D2", "D1Id", "dbo.D1");
            DropIndex("dbo.D2", new[] { "D1Id" });
            DropTable("dbo.D2");
            DropTable("dbo.D1");
        }
    }
}
