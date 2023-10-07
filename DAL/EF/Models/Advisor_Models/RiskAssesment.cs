using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Advisor_Models
{
    public class RiskAssesment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserIntereset { get; set; }
        [Required]
        public string RiskInInvest { get; set; }
        [Required]
        public string MarketDemand { get; set; }
        [Required]
        public string Severe { get; set; }
    }
}
