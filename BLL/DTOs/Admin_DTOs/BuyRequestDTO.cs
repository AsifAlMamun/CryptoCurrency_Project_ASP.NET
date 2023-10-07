using DAL.EF.Models.User_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Admin_DTOs
{
    public class BuyRequestDTO
    {
        public int Id { get; set; }
        public string Cryptocurrency { get; set; }
        public int UserId { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }

    }
}
