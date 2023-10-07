using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Advisor_DTOs
{
    public class LoanDTO
    {
        public int Id { get; set; }



        public string Loan_Type { get; set; }



        public string Interest { get; set; }



        public string LoanStatus { get; set; }



        public string LoanCause { get; set; }
    }
}
