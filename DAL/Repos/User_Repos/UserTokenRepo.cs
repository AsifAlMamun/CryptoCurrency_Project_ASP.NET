using DAL.EF.Models.User_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.User_Repos
{
    internal class UserTokenRepo : Repo, ICrud<UserToken, int, UserToken>
    {
        public UserToken Create(UserToken obj)
        {
            db.UserTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserToken> Get()
        {
            throw new NotImplementedException();
        }

        public UserToken Get(int id)
        {
            throw new NotImplementedException();
        }

        public UserToken Update(UserToken obj)
        {
            throw new NotImplementedException();
        }
    }
}
