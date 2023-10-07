namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OtherTablesCreation2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdvisorTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        AdvisorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdvisorDetails", t => t.AdvisorId, cascadeDelete: true)
                .Index(t => t.AdvisorId);
            
            CreateTable(
                "dbo.EmployeeTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.UserTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TokenKey = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpiredAt = c.DateTime(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            AlterColumn("dbo.AdvisorDetails", "Username", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String());
            AlterColumn("dbo.Employees", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTokens", "UserId", "dbo.Users");
            DropForeignKey("dbo.EmployeeTokens", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.AdvisorTokens", "AdvisorId", "dbo.AdvisorDetails");
            DropIndex("dbo.UserTokens", new[] { "UserId" });
            DropIndex("dbo.EmployeeTokens", new[] { "EmployeeId" });
            DropIndex("dbo.AdvisorTokens", new[] { "AdvisorId" });
            AlterColumn("dbo.Employees", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.AdvisorDetails", "Username", c => c.String(nullable: false));
            DropTable("dbo.UserTokens");
            DropTable("dbo.EmployeeTokens");
            DropTable("dbo.AdvisorTokens");
        }
    }
}
