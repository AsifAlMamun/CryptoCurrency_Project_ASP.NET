using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models.User_Models
{
    public class Voucher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string V_avaible { get; set; }
        public DateTime V_valid { set; get; }

        [ForeignKey("User")]
        public int U_ID { get; set; }
        public virtual User User { get; set; }
    }
}
