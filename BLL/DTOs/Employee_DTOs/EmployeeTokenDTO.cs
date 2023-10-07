﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Employee_DTOs
{
    public class EmployeeTokenDTO
    {
        public int Id { get; set; }
        public string TokenKey { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public int EmployeeId { get; set; }
    }
}
