using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.User_Models
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CurrencyName { get; set; }
        [Required]
        public string CurrencyBalance { get; set; }

        [ForeignKey("User")]
        public int U_ID { get; set; }
        public virtual User User { get; set; }
    }
}
