namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupportTicketAndEmployee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupportTickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Subject = c.String(),
                        Description = c.String(),
                        Priority = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
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
            DropForeignKey("dbo.SupportTickets", "UserId", "dbo.Users");
            DropForeignKey("dbo.SupportTickets", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.SupportTickets", new[] { "EmployeeId" });
            DropIndex("dbo.SupportTickets", new[] { "UserId" });
            DropTable("dbo.Employees");
            DropTable("dbo.SupportTickets");
        }
    }
}
