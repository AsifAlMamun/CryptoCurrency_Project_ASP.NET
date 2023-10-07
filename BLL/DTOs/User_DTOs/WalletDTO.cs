using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.User_DTOs
{
    public class WalletDTO
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyBalance { get; set; }
        public int U_ID { get; set; }
    }
}
