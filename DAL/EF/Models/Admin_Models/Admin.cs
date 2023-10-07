using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.Admin_Models
{
    public class Admin
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        [Key]
        [Column(Order = 1)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Token> Tokens { get; set; }
        public Admin()
        {
            Tokens = new List<Token>();
        }
    }
}
