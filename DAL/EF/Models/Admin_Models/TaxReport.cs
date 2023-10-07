using DAL.EF.Models.User_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Admin_Models
{
    public class TaxReport
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public decimal TotalGains { get; set; }
        public decimal TotalLosses { get; set; }



        public virtual User User { get; set; }
    }
}
