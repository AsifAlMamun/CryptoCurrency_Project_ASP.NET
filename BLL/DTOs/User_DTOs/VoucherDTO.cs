using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.User_DTOs
{
    public class VoucherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string V_avaible { get; set; }



        public DateTime V_valid { set; get; }




        public int U_ID { get; set; }
    }
}
