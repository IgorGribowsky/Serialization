using Serialization.Core.Models;
using System;
using System.Collections.Generic;

namespace Serialization.DeepCloning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var department = new Department()
            {
                DepartmentName = "Department",
                Employees = new List<Employee>()
                {
                    new Employee() { EmpoyeeName = "Ales" },
                    new Employee() { EmpoyeeName = "Petr" },
                }
            };

            var duplicator = new Duplicator();

            var clonedDepartment = duplicator.Clone(department);

            var objectsAreCompletelyIndependent = true;

            if (department == clonedDepartment)
            {
                objectsAreCompletelyIndependent = false;
            }

            for (int i = 0; i < department.Employees.Count; i++)
            {
                if (department.Employees[i] == clonedDepartment.Employees[i])
                {
                    objectsAreCompletelyIndependent = false;
                }
            }

            var message = objectsAreCompletelyIndependent
                ? "Objects are completely independent!"
                : "Objects are not independent!";

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
