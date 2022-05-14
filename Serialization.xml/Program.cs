using Serialization.Core.Models;
using System;
using System.Collections.Generic;

namespace Serialization.xml
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

            var filePath = "department.xml";
            var serializator = new XmlSerializator();
            serializator.Serialize<Department>(objectToSerialize, filePath);
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
