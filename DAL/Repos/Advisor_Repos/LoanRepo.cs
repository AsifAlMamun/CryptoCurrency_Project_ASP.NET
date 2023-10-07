using DAL.EF.Models.Advisor_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Advisor_Repos
{
    internal class LoanRepo:Repo,ICrud<Loan,int,bool>
    {
        public bool Create(Loan loan)
        {
            db.Loans.Add(loan);
            return db.SaveChanges() > 0;
        }



        public bool Delete(int id)
        {
            var exloan = db.Loans.Find(id);
            db.Loans.Remove(exloan);
            return db.SaveChanges() > 0;
        }



        public List<Loan> Get()
        {
            return db.Loans.ToList();
        }



        public Loan Get(int id)
        {
            return db.Loans.Find(id);
        }
        public bool Update(Loan loan)
        {
            var exloan = db.Loans.Find(loan.Id);
            exloan.Loan_Type = loan.Loan_Type;
            exloan.Interest = loan.Interest;
            exloan.LoanStatus = loan.LoanStatus;
            exloan.LoanCause = loan.LoanCause;



            exloan.U_Id = loan.U_Id;



            return db.SaveChanges() > 0;
        }
    }
}
