using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Admin_DTOs
{
    public class CurrencyDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }

        public string MarketCap { get; set; }

        public string Volume { get; set; }

        public string Supply { get; set; }
    }
}
