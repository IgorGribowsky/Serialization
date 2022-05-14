using System;

namespace Serialization.OwnBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat()
            {
                Name = "Barsik",
                Age = 2,
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
