using DAL.EF.Models;
using DAL.EF.Models.Admin_Models;
using DAL.EF.Models.Advisor_Models;
using DAL.EF.Models.Employee_Models;
using DAL.EF.Models.User_Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class ProjectContext:DbContext
    {
        public DbSet<Currency> Currencies { get; set; }

        public DbSet<Content> Contents { get; set; }

        public DbSet<BuyRequest> BuyRequests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SupportTicket> SupportTickets { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<TaxReport> TaxReports { get; set; }
        public DbSet<AdvisorDetail>AdvisorDetails { get; set; }
        public DbSet<Loan>Loans { get; set; }
        public DbSet<Planning>Plannings { get; set; }
        public DbSet<RiskAssesment>RiskAssesments { get; set; }
        public DbSet<Salary>Salaries { get; set; }



        public DbSet<Token> Tokens { get; set; }
        public DbSet<AdvisorToken> AdvisorTokens { get; set; }
        public DbSet<EmployeeToken> EmployeeTokens { get; set; }
        public DbSet<UserToken> UserTokens { get; set; }
    }
}
