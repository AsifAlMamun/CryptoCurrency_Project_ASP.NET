using DAL.EF.Models.Advisor_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Advisor_Repos
{
    internal class AdvisorDetailsRepo : Repo, ICrud<AdvisorDetail, int, bool>, IAuth<AdvisorDetail>
    {
        public AdvisorDetail Authenticate(string username, string password)
        {
            var user = from u in db.AdvisorDetails
                       where u.Username.Equals(username) &&
                       u.Password.Equals(password)
                       select u;
            if (user != null) return user.SingleOrDefault();
            return null;
        }

        public bool Create(AdvisorDetail advisordetails)
        {
            db.AdvisorDetails.Add(advisordetails);
            return db.SaveChanges() > 0;
        }



        public bool Delete(int id)
        {
            var exadvisordetails = db.AdvisorDetails.Find(id);
            db.AdvisorDetails.Remove(exadvisordetails);
            return db.SaveChanges() > 0;
        }



        public List<AdvisorDetail> Get()
        {
            return db.AdvisorDetails.ToList();
        }



        public AdvisorDetail Get(int id)
        {
            return db.AdvisorDetails.Find(id);
        }
        public bool Update(AdvisorDetail advisordetails)
        {
            var exadvisordetails = db.AdvisorDetails.Find(advisordetails.Id);
            exadvisordetails.Name = advisordetails.Name;
            exadvisordetails.Username = advisordetails.Username;
            exadvisordetails.Email = advisordetails.Email;
            exadvisordetails.Password = advisordetails.Password;


            return db.SaveChanges() > 0;
        }
    }
}
