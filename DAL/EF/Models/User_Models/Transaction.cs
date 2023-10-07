using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.User_Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string CryptocurrencyType { get; set; }
        public string TransactionType { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }

        public virtual User User { get; set; }

    }
}
