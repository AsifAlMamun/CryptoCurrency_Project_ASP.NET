namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tokentable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Admins");
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        AdminId = c.Int(nullable: false),
                        Username = c.String(maxLength: 128),
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => new { t.AdminId, t.Username })
                .Index(t => new { t.AdminId, t.Username });
            
            AlterColumn("dbo.Admins", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Admins", "Username", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Admins", new[] { "Id", "Username" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tokens", new[] { "AdminId", "Username" }, "dbo.Admins");
            DropIndex("dbo.Tokens", new[] { "AdminId", "Username" });
            DropPrimaryKey("dbo.Admins");
            AlterColumn("dbo.Admins", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Tokens");
            AddPrimaryKey("dbo.Admins", "Id");
        }
    }
}
