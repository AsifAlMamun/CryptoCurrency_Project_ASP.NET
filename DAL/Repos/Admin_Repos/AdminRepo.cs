using DAL.EF.Models.Admin_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin_Repos
{
    internal class AdminRepo:Repo,ICrud<Admin,int, bool>,IAuth<Admin>
    {
        public bool Create(Admin admin)
        {
            db.Admins.Add(admin);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exAdmin = db.Admins.Find(id);
            db.Admins.Remove(exAdmin);
            return db.SaveChanges() > 0;
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int id)
        {
            return db.Admins.Find(id);
        }

        public bool Update(Admin admin)
        {
            var exAdmin = db.Admins.Find(admin.Id);
            exAdmin.Username = admin.Username;
            exAdmin.Password = admin.Password;

            return db.SaveChanges() > 0;
        }

        public Admin Authenticate(string username, string password)
        {
            var user = from u in db.Admins
                       where u.Username.Equals(username) &&
                       u.Password.Equals(password)
                       select u;
            if (user != null) return user.SingleOrDefault();
            return null;
        }
    }
}
