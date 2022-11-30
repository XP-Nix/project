namespace project3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accesses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Level = c.Int(nullable: false),
                        Description = c.String(),
                        DateIDK = c.DateTime(nullable: false),
                        DoubleIDK = c.Double(nullable: false),
                        LongIDK = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        Rank = c.Double(nullable: false),
                        LongIDK = c.Long(nullable: false),
                        AccessID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accesses", t => t.AccessID, cascadeDelete: true)
                .Index(t => t.AccessID);
            
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CardName = c.String(),
                        Description = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                        CardRank = c.Double(nullable: false),
                        Points = c.Int(nullable: false),
                        LongIDK = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "AccessID", "dbo.Accesses");
            DropIndex("dbo.Accounts", new[] { "AccessID" });
            DropTable("dbo.Cards");
            DropTable("dbo.Accounts");
            DropTable("dbo.Accesses");
        }
    }
}
