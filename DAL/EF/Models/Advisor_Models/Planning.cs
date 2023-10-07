using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Advisor_Models
{
    public class Planning
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string How_plan { get; set; }
        [Required]
        public string Benifit { get; set; }
        [Required]
        public string CashFlow { get; set; }
        [Required]
        public string Opinion { get; set; }
    }
}
