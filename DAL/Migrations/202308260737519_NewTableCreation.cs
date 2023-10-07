namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cryptocurrency = c.String(),
                        UserId = c.Int(nullable: false),
                        Price = c.String(),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BuyRequests", "UserId", "dbo.Users");
            DropIndex("dbo.BuyRequests", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.BuyRequests");
        }
    }
}
