using DAL.EF.Models.Admin_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin_Repos
{
    internal class BuyRequestRepo : Repo, ICrud<BuyRequest, int, bool>
    {
        public bool Create(BuyRequest brequest)
        {
            db.BuyRequests.Add(brequest);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exRequest = db.BuyRequests.Find(id);
            db.BuyRequests.Remove(exRequest);
            return db.SaveChanges() > 0;
        }

        public List<BuyRequest> Get()
        {
            return db.BuyRequests.ToList();
        }

        public BuyRequest Get(int id)
        {
            return db.BuyRequests.Find(id);
        }

        public bool Update(BuyRequest request)
        {
            var exRequest = db.BuyRequests.Find(request.Id);
            exRequest.Cryptocurrency = request.Cryptocurrency;
            exRequest.UserId = request.UserId;
            exRequest.Price = request.Price;
            exRequest.Amount = request.Amount;

            return db.SaveChanges() > 0;
        }
    }
}
