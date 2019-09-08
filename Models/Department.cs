using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace klovecore2.Models
{
    public class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }
        public int DepartmentID { get; set; }
        public string Name { get; set; }       
        public int? PhoneNumber { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
