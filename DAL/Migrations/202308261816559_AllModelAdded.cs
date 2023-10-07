namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CryptocurrencyType = c.String(),
                        TransactionType = c.String(),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Vouchers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        V_avaible = c.String(),
                        V_valid = c.DateTime(nullable: false),
                        U_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.U_ID, cascadeDelete: true)
                .Index(t => t.U_ID);
            
            CreateTable(
                "dbo.TaxReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TotalGains = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalLosses = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Wallets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyName = c.String(nullable: false),
                        CurrencyBalance = c.String(nullable: false),
                        U_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.U_ID, cascadeDelete: true)
                .Index(t => t.U_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wallets", "U_ID", "dbo.Users");
            DropForeignKey("dbo.TaxReports", "UserId", "dbo.Users");
            DropForeignKey("dbo.Vouchers", "U_ID", "dbo.Users");
            DropForeignKey("dbo.Transactions", "UserId", "dbo.Users");
            DropIndex("dbo.Wallets", new[] { "U_ID" });
            DropIndex("dbo.TaxReports", new[] { "UserId" });
            DropIndex("dbo.Vouchers", new[] { "U_ID" });
            DropIndex("dbo.Transactions", new[] { "UserId" });
            DropTable("dbo.Wallets");
            DropTable("dbo.TaxReports");
            DropTable("dbo.Vouchers");
            DropTable("dbo.Transactions");
            DropTable("dbo.Admins");
        }
    }
}
