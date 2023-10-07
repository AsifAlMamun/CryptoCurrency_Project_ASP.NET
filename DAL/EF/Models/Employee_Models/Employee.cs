using DAL.EF.Models.Admin_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Employee_Models
{
    public class Employee
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

        public virtual ICollection<SupportTicket> SupportTickets { get; set; }
        public virtual ICollection<EmployeeToken> EmployeeTokens { get; set; }
        public Employee()
        {
            SupportTickets = new List<SupportTicket>();
            EmployeeTokens = new List<EmployeeToken>();
        }
    }
}
