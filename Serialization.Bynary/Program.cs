using Serialization.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization.Bynary
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

            var filePath = "department.dat";
            var binarySerializator = new BinarySerializator();
            binarySerializator.Serialize(objectToSerialize, filePath);
            var resultDepartment = binarySerializator.Deserialize<Department>(filePath);

            Console.WriteLine(resultDepartment.DepartmentName);
            foreach (var employee in resultDepartment.Employees)
            {
                Console.WriteLine("  "+employee.EmpoyeeName);
            }
            Console.ReadLine();
        }
    }
}
