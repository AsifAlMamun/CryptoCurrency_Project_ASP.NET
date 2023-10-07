using DAL.EF.Models.Advisor_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Advisor_Repos
{
    internal class PlanningRepo:Repo,ICrud<Planning,int,bool>
    {
        public bool Create(Planning plan)
        {
            db.Plannings.Add(plan);
            return db.SaveChanges() > 0;
        }



        public bool Delete(int id)
        {
            var explan = db.Plannings.Find(id);
            db.Plannings.Remove(explan);
            return db.SaveChanges() > 0;
        }



        public List<Planning> Get()
        {
            return db.Plannings.ToList();
        }



        public Planning Get(int id)
        {
            return db.Plannings.Find(id);
        }
        public bool Update(Planning plan)
        {
            var explan = db.Plannings.Find(plan.Id);
            explan.How_plan = plan.How_plan;
            explan.Benifit = plan.Benifit;
            explan.CashFlow = plan.CashFlow;
            explan.Opinion = plan.Opinion;



            return db.SaveChanges() > 0;
        }
    }
}
