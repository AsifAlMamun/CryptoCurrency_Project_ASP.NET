using DAL.EF.Models.Admin_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Advisor_Models
{
    public class AdvisorToken
    {
        public int Id { get; set; }
        public string TokenKey { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }

        [ForeignKey("AdvisorDetail")]
        public int AdvisorId { get; set; }
        public virtual AdvisorDetail AdvisorDetail { get; set; }
    }
}
