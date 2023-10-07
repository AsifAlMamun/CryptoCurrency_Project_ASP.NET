using DAL.EF.Models.User_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.User_Repos
{
    internal class WalletRepo:Repo,ICrud<Wallet,int,bool>
    {
        public bool Create(Wallet w)
        {
            db.Wallets.Add(w);
            return db.SaveChanges() > 0;
        }



        public bool Delete(int id)
        {
            var exWallet = db.Wallets.Find(id);
            db.Wallets.Remove(exWallet);
            return db.SaveChanges() > 0;
        }



        public List<Wallet> Get()
        {
            return db.Wallets.ToList();
        }



        public Wallet Get(int id)
        {
            return db.Wallets.Find(id);
        }



        public bool Update(Wallet w)
        {
            var exWallet = db.Wallets.Find(w.Id);
            exWallet.CurrencyName = w.CurrencyName;
            exWallet.CurrencyBalance = w.CurrencyBalance;



            exWallet.U_ID = w.U_ID;



            return db.SaveChanges() > 0;
        }
    }
}
