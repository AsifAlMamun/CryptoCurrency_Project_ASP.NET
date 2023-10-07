using DAL.EF.Models.Admin_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.User_Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<BuyRequest> BuyRequests { get; set; }
        public virtual ICollection<SupportTicket> SupportTickets { get; set; }
        public virtual ICollection<Transaction>Transactions { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
        public virtual ICollection<UserToken> UserTokens { get; set; }
        public virtual ICollection<TaxReport> TaxReports { get; set; }

        public User()
        {
            BuyRequests = new List<BuyRequest>();
            SupportTickets = new List<SupportTicket>();
            Transactions = new List<Transaction>();
            Vouchers = new List<Voucher>();
            TaxReports = new List<TaxReport>();
            UserTokens = new List<UserToken>();
        }
    }
}
