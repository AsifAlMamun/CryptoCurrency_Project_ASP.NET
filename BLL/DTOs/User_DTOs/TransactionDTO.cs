using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.User_DTOs
{
    public class TransactionDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string CryptocurrencyType { get; set; }
        public string TransactionType { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal Price { get; set; }
    }
}
