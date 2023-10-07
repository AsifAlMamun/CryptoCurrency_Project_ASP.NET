using DAL.EF.Models.Admin_Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Admin_Repos
{
    internal class SupportTicketRepo : Repo, ICrud<SupportTicket, int, bool>
    {
        public bool Create(SupportTicket ticket)
        {
            db.SupportTickets.Add(ticket);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var exTicket = db.SupportTickets.Find(id);
            db.SupportTickets.Remove(exTicket);
            return db.SaveChanges() > 0;
        }

        public List<SupportTicket> Get()
        {
            return db.SupportTickets.ToList();
        }

        public SupportTicket Get(int id)
        {
            return db.SupportTickets.Find(id);
        }

        public bool Update(SupportTicket ticket)
        {
            var exTicket = db.SupportTickets.Find(ticket.Id);
            exTicket.UserId = ticket.UserId;
            exTicket.EmployeeId = ticket.EmployeeId;
            exTicket.Subject = ticket.Subject;
            exTicket.Description = ticket.Description;
            exTicket.Priority = ticket.Priority;
            exTicket.CreatedAt = ticket.CreatedAt;

            return db.SaveChanges() > 0;
        }
    }
}
