using System;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeService employeeService = new EmployeeService();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine(" SISTEMA DE GESTIÓN DE EMPLEADOS ");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Registrar empleado");
                Console.WriteLine("2. Salir");
                Console.WriteLine("====================================");
                Console.Write("Seleccione una opción: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RegisterEmployee(employeeService);
                        break;

                    case "2":
                        exit = true;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void RegisterEmployee(EmployeeService employeeService)
        {
            Console.Clear();
            Console.WriteLine("=== REGISTRO DE EMPLEADO ===");

            Console.Write("Ingrese el ID del empleado: ");
            bool isValidId = int.TryParse(Console.ReadLine(), out int id);

            if (!isValidId)
            {
                Console.WriteLine("Error: El ID debe ser un número válido.");
                return;
            }

            Console.Write("Ingrese el nombre completo: ");
            string fullName = Console.ReadLine();

            Console.Write("Ingrese el correo electrónico: ");
            string email = Console.ReadLine();

            Console.Write("Ingrese la fecha de finalización del contrato (yyyy-MM-dd): ");
            bool isValidDate = DateTime.TryParse(Console.ReadLine(), out DateTime contractEndDate);

            if (!isValidDate)
            {
                Console.WriteLine("Error: La fecha ingresada no es válida.");
                return;
            }

            string result = employeeService.RegisterEmployee(
                id,
                fullName,
                email,
                contractEndDate
            );

            Console.WriteLine(result);
        }
    }
}
