using System.Text.Json;

namespace Serialization.DeepCloning
{
    public class Duplicator
    {
        public T Clone<T>(T objectToClone)
        {
            var serializedObject = JsonSerializer.Serialize(objectToClone);
            return JsonSerializer.Deserialize<T>(serializedObject);
        }
    }
}
