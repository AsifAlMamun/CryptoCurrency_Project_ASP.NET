using DAL.EF.Models.Admin_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin_Repos
{
    internal class CurrencyRepo : Repo, ICrud<Currency, int, bool>
    {
        public bool Create(Currency currency)
        {
            db.Currencies.Add(currency);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exCurrency = db.Currencies.Find(id);
            db.Currencies.Remove(exCurrency);
            return db.SaveChanges() > 0;
        }

        public List<Currency> Get()
        {
            return db.Currencies.ToList();
        }

        public Currency Get(int id)
        {
            return db.Currencies.Find(id);
        }

        public bool Update(Currency currency)
        {
            var exCurrency = db.Currencies.Find(currency.Id);
            exCurrency.Name = currency.Name;
            exCurrency.Price = currency.Price;
            exCurrency.MarketCap = currency.MarketCap;
            exCurrency.Volume = currency.Volume;
            exCurrency.Supply = currency.Supply;

            return db.SaveChanges() > 0;
        }
    }
}
