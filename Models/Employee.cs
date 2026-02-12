using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    internal class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public decimal Salary { get; set; }

        public string Status { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
