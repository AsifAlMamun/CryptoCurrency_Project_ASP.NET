using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Advisor_Models
{
    public class AdvisorDetail
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

        public virtual ICollection<AdvisorToken> AdvisorTokens { get; set; }
        public AdvisorDetail()
        {
            AdvisorTokens = new List<AdvisorToken>();
        }
    }
}
