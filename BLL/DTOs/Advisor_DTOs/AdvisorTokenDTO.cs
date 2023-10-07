using DAL.EF.Models.Advisor_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Advisor_DTOs
{
    public class AdvisorTokenDTO
    {
        public int Id { get; set; }
        public string TokenKey { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public int AdvisorId { get; set; }

    }
}
