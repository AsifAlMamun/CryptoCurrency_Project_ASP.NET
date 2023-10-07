using DAL.EF.Models.Admin_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin_Repos
{
    internal class TaxReportRepo : Repo, ICrud<TaxReport, int, bool>
    {
        public bool Create(TaxReport report)
        {
            db.TaxReports.Add(report);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exReport = db.TaxReports.Find(id);
            db.TaxReports.Remove(exReport);
            return db.SaveChanges() > 0;
        }

        public List<TaxReport> Get()
        {
            return db.TaxReports.ToList();
        }

        public TaxReport Get(int id)
        {
            return db.TaxReports.Find(id);
        }

        public bool Update(TaxReport report)
        {
            var exReport = db.TaxReports.Find(report.Id);
            exReport.UserId = report.UserId;
            exReport.TotalGains = report.TotalGains;
            exReport.TotalLosses = report.TotalLosses;

            return db.SaveChanges() > 0;
        }
    }
}
