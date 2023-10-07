namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OtherTablesCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdvisorDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Loan_Type = c.String(nullable: false),
                        Interest = c.String(nullable: false),
                        LoanStatus = c.String(nullable: false),
                        LoanCause = c.String(nullable: false),
                        U_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.U_Id, cascadeDelete: true)
                .Index(t => t.U_Id);
            
            CreateTable(
                "dbo.Plannings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        How_plan = c.String(nullable: false),
                        Benifit = c.String(nullable: false),
                        CashFlow = c.String(nullable: false),
                        Opinion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RiskAssesments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserIntereset = c.String(nullable: false),
                        RiskInInvest = c.String(nullable: false),
                        MarketDemand = c.String(nullable: false),
                        Severe = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Designation = c.String(nullable: false),
                        EmployeeSalary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loans", "U_Id", "dbo.Users");
            DropIndex("dbo.Loans", new[] { "U_Id" });
            DropTable("dbo.Salaries");
            DropTable("dbo.RiskAssesments");
            DropTable("dbo.Plannings");
            DropTable("dbo.Loans");
            DropTable("dbo.AdvisorDetails");
        }
    }
}
