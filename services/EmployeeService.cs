using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services
{
    public class EmployeeService
    {
        private readonly List<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee>();
        }
    }
}