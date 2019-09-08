using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace klovecore2.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }       


        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
     
    }
}
