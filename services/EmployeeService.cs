using EmployeeManagement.Models;
using System;
using System.Collections.Generic;

namespace EmployeeManagement.Services
{
    public class EmployeeService
    {
        private readonly List<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee>();
        }

        public string RegisterEmployee(
            int id,
            string fullName,
            string email,
            DateTime contractEndDate)
        {
            if (id <= 0)
            {
                return "Error: El ID del empleado debe ser mayor que cero.";
            }

            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "Error: El nombre completo es obligatorio.";
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                return "Error: El correo electrónico no es válido.";
            }

            if (contractEndDate <= DateTime.Today)
            {
                return "Error: La fecha de finalización del contrato debe ser futura.";
            }

            bool employeeExists = employees.Exists(e => e.Id == id);
            if (employeeExists)
            {
                return "Error: Ya existe un empleado con este ID.";
            }

            Employee newEmployee = new Employee
            {
                Id = id,
                FullName = fullName,
                Email = email,
                IsActive = true,
                ContractEndDate = contractEndDate
            };

            employees.Add(newEmployee);

            return "Empleado registrado exitosamente.";
        }
        public Employee GetEmployeeById(int id)
        {
            if (id <= 0)
            {
                return null;
            }

            return employees.Find(e => e.Id == id);
        }

    }
}
