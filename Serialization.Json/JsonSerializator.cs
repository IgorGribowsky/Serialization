using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Serialization.Json
{
    public class JsonSerializator
    {
        public T Deserialize<T>(string filePath)
            where T : class
        {
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

        public void Serialize(object objectToSerialize, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(objectToSerialize);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
