using DAL.EF.Models.User_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Advisor_Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Loan_Type { get; set; }
        [Required]
        public string Interest { get; set; }
        [Required]
        public string LoanStatus { get; set; }
        [Required]
        public string LoanCause { get; set; }
        [ForeignKey("Users")]

        public int U_Id { get; set; }
        public virtual User Users { get; set; }
    }
}
