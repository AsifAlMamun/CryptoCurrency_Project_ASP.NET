using DAL.EF.Models.User_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.User_Repos
{
    internal class VoucherRepo : Repo, ICrud<Voucher, int, bool>
    {
        public bool Create(Voucher v)
        {
            db.Vouchers.Add(v);
            return db.SaveChanges() > 0;
        }



        public bool Delete(int id)
        {
            var exvou = db.Vouchers.Find(id);
            db.Vouchers.Remove(exvou);
            return db.SaveChanges() > 0;
        }



        public List<Voucher> Get()
        {
            return db.Vouchers.ToList();
        }



        public Voucher Get(int id)
        {
            return db.Vouchers.Find(id);
        }



        public bool Update(Voucher v)
        {
            var exvou = Get(v.Id);
            db.Entry(exvou).CurrentValues.SetValues(v);
            return db.SaveChanges() > 0;





        }
    }
}
