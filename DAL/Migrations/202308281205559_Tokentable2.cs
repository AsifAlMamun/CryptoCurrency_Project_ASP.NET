namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tokentable2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Tokens", new[] { "AdminId", "Username" });
            AlterColumn("dbo.Tokens", "AdminId", c => c.Int());
            CreateIndex("dbo.Tokens", new[] { "AdminId", "Username" });
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tokens", new[] { "AdminId", "Username" });
            AlterColumn("dbo.Tokens", "AdminId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tokens", new[] { "AdminId", "Username" });
        }
    }
}
