using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

            var filePath = "cat.dat";
            Serialize(cat, filePath);
            var resultCat = Deserialize(filePath);

            Console.WriteLine("Name: " + resultCat.Name);
            Console.WriteLine("Age: " + resultCat.Age);
            Console.ReadLine();
        }

        public static Cat Deserialize(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return (Cat)formatter.Deserialize(fs);
            }
        }

        public static void Serialize(Cat cat, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, cat);
            }
        }
    }
}
