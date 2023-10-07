using DAL.EF.Models;
using DAL.EF.Models.Admin_Models;
using DAL.EF.Models.Advisor_Models;
using DAL.EF.Models.Employee_Models;
using DAL.EF.Models.User_Models;
using DAL.Interfaces;
using DAL.Repos;
using DAL.Repos.Admin_Repos;
using DAL.Repos.Advisor_Repos;
using DAL.Repos.Employee_Repos;
using DAL.Repos.User_Repos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static ICrud<Currency, int, bool> CurrencyData()
        {
            return new CurrencyRepo();
        }

        public static ICrud<Content, int, bool> ContentData()
        {
            return new ContentRepo();
        }

        public static ICrud<BuyRequest, int, bool> RequestData()
        {
            return new BuyRequestRepo();
        }

        public static ICrud<SupportTicket, int, bool> TicketData()
        {
            return new SupportTicketRepo();
        }

        public static ICrud<Admin, int, bool> AdminData()
        {
            return new AdminRepo();
        }

        public static IAuth<Admin> AuthData()
        {
            return new AdminRepo();
        }

        public static IAuth<AdvisorDetail> AdvisorAuthData()
        {
            return new AdvisorDetailsRepo();
        }

        public static IAuth<User> UserAuthData()
        {
            return new UserRepo();
        }

        public static IAuth<Employee> EmployeeAuthData()
        {
            return new EmployeeRepo();
        }

        public static ICrud<TaxReport, int, bool> ReportData()
        {

            return new TaxReportRepo();

        }

        public static ICrud<Token, int, Token> TokenData()
        {
            return new TokenRepo();
        }


        public static ICrud<Loan, int, bool> LoanData()
        {
            return new LoanRepo();
        }
        public static ICrud<Planning, int, bool> PlanningData()
        {
            return new PlanningRepo();
        }
        public static ICrud<RiskAssesment, int, bool> RiskAssesmentData()
        {
            return new RiskAssesmentRepo();
        }
        public static ICrud<AdvisorDetail, int, bool> AdvisordetailssData()
        {
            return new AdvisorDetailsRepo();
        }

        public static ICrud<AdvisorToken, int, AdvisorToken> AdvisorTokenData()
        {
            return new AdvisorTokenRepo();
        }

        public static ICrud<User, int, bool> UserData()
        {
            return new UserRepo();
        }



        public static ICrud<Wallet, int, bool> WalletData()
        {
            return new WalletRepo();
        }
        public static ICrud<Transaction, int, bool> TransactionData()
        {
            return new TransactionRepo();
        }



        public static ICrud<Voucher, int, bool> VoucherData()
        {
            return new VoucherRepo();
        }

        public static ICrud<UserToken, int, UserToken> UserTokenData()
        {
            return new UserTokenRepo();
        }
        public static ICrud<Employee, int, bool> EmployeeData()
        {
            return new EmployeeRepo();

        }
        public static ICrud<Salary, int, bool> SalaryData()
        {
            return new SalaryRepo();

        }



        public static ICrud<EmployeeToken, int, EmployeeToken> EmployeeTokenData()
        {
            return new EmployeeTokenRepo();
        }
    }
}
