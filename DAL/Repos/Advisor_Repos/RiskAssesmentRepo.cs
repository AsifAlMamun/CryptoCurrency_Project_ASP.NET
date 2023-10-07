using DAL.EF.Models.Advisor_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Advisor_Repos
{
    internal class RiskAssesmentRepo:Repo,ICrud<RiskAssesment,int,bool>
    {
        public bool Create(RiskAssesment riskassesment)
        {
            db.RiskAssesments.Add(riskassesment);
            return db.SaveChanges() > 0;
        }



        public bool Delete(int id)
        {
            var exriskassesment = db.RiskAssesments.Find(id);
            db.RiskAssesments.Remove(exriskassesment);
            return db.SaveChanges() > 0;
        }



        public List<RiskAssesment> Get()
        {
            return db.RiskAssesments.ToList();
        }



        public RiskAssesment Get(int id)
        {
            return db.RiskAssesments.Find(id);
        }
        public bool Update(RiskAssesment riskassesment)
        {
            var exriskassesment = db.RiskAssesments.Find(riskassesment.Id);
            exriskassesment.UserIntereset = riskassesment.UserIntereset;
            exriskassesment.RiskInInvest = riskassesment.RiskInInvest;
            exriskassesment.MarketDemand = riskassesment.MarketDemand;
            exriskassesment.Severe = riskassesment.Severe;



            return db.SaveChanges() > 0;
        }
    }
}
