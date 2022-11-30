namespace project3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()//plz work
        {
            AlterColumn("dbo.Cards", "CardName", c => c.String(nullable: false, maxLength: 160));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cards", "CardName", c => c.String());
        }
    }
}
