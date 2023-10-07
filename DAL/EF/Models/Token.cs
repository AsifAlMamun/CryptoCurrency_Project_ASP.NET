using DAL.EF.Models.Admin_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Token
    {
        public int Id { get; set; }
        public string TokenKey { get; set; }
        [ForeignKey("Admin")]
        [Column(Order = 1)]
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }

       [ForeignKey("Admin")]
       [Column(Order = 0)]
       public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
