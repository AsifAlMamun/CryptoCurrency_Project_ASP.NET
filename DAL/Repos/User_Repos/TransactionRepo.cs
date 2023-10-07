using DAL.EF.Models.User_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.User_Repos
{
    internal class TransactionRepo:Repo, ICrud<Transaction, int, bool>
    {
        public bool Create(Transaction t)
        {
            db.Transactions.Add(t);
            return db.SaveChanges() > 0;
        }



        public bool Delete(int id)
        {
            var extran = db.Transactions.Find(id);
            db.Transactions.Remove(extran);
            return db.SaveChanges() > 0;
        }



        public List<Transaction> Get()
        {
            return db.Transactions.ToList();
        }



        public Transaction Get(int id)
        {
            return db.Transactions.Find(id);
        }



        public bool Update(Transaction t)
        {
            var ex = Get(t.Id);
            db.Entry(ex).CurrentValues.SetValues(t);
            return db.SaveChanges() > 0;





        }
    }
}
