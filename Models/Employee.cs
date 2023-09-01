using System;
using System.Collections.Generic;

namespace mvcProject.Models
{
    public partial class Employee
    {
        public uint EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
