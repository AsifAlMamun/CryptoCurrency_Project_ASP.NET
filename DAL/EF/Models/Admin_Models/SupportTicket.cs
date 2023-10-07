using DAL.EF.Models.Employee_Models;
using DAL.EF.Models.User_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Admin_Models
{
    public class SupportTicket
    {
        public int Id { get; set; }
        [ForeignKey("User")]
       
        public int UserId { get; set; }
        [ForeignKey("Employee")]
      
        public int EmployeeId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual User User { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
