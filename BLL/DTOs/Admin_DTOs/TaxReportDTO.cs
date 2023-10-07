using DAL.EF.Models.User_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Admin_DTOs
{
    public class TaxReportDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal TotalGains { get; set; }
        public decimal TotalLosses { get; set; }

    }
}
