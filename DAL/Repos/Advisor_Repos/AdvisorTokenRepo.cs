using DAL.EF.Models.Advisor_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Advisor_Repos
{
    internal class AdvisorTokenRepo : Repo, ICrud<AdvisorToken, int, AdvisorToken>
    {
        public AdvisorToken Create(AdvisorToken obj)
        {
            db.AdvisorTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AdvisorToken> Get()
        {
            throw new NotImplementedException();
        }

        public AdvisorToken Get(int id)
        {
            throw new NotImplementedException();
        }

        public AdvisorToken Update(AdvisorToken obj)
        {
            throw new NotImplementedException();
        }
    }
}
