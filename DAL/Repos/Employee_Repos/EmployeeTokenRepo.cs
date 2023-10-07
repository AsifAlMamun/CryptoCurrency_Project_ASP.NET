using DAL.EF.Models.Employee_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Employee_Repos
{
    internal class EmployeeTokenRepo : Repo, ICrud<EmployeeToken, int, EmployeeToken>
    {
        public EmployeeToken Create(EmployeeToken obj)
        {
            db.EmployeeTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeToken> Get()
        {
            throw new NotImplementedException();
        }

        public EmployeeToken Get(int id)
        {
            throw new NotImplementedException();
        }

        public EmployeeToken Update(EmployeeToken obj)
        {
            throw new NotImplementedException();
        }
    }
}
