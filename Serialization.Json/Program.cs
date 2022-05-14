using System;
using System.Collections.Generic;
using Serialization.Core.Models;

namespace Serialization.Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objectToSerialize = new Department()
            {
                DepartmentName = "Department",
                Employees = new List<Employee>()
                {
                    new Employee() { EmpoyeeName = "Ales" },
                    new Employee() { EmpoyeeName = "Petr" },
                }
            };

            var filePath = "department.json";
            var serializator = new JsonSerializator();
            serializator.Serialize(objectToSerialize, filePath);
            var resultDepartment = serializator.Deserialize<Department>(filePath);

            Console.WriteLine(resultDepartment.DepartmentName);
            foreach (var employee in resultDepartment.Employees)
            {
                Console.WriteLine("  " + employee.EmpoyeeName);
            }
            Console.ReadLine();
        }
    }
}
