using DAL.EF.Models.User_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.User_Repos
{
    internal class UserRepo:Repo,ICrud<User,int,bool>,IAuth<User>
    {
        public bool Create(User user)
        {
            db.Users.Add(user);
            return db.SaveChanges() > 0;
        }



        public bool Delete(int id)
        {
            var exUser = db.Users.Find(id);
            db.Users.Remove(exUser);
            return db.SaveChanges() > 0;
        }



        public List<User> Get()
        {
            return db.Users.ToList();
        }



        public User Get(int id)
        {
            return db.Users.Find(id);
        }



        public bool Update(User user)
        {
            var exUser = db.Users.Find(user.Id);
            exUser.Name = user.Name;
            exUser.Username = user.Username;
            exUser.Email = user.Email;
            exUser.Password = user.Password;



            return db.SaveChanges() > 0;
        }

        public User Authenticate(string username, string password)
        {
            var user = from u in db.Users
                       where u.Username.Equals(username) &&
                       u.Password.Equals(password)
                       select u;
            if (user != null) return user.SingleOrDefault();
            return null;
        }
    }
}
