using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization.Bynary
{
    public class BinarySerializator
    {
        public T Deserialize<T>(string filePath)
            where T : class
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return (T)formatter.Deserialize(fs);
            }
        }

        public void Serialize(object objectToSerialize, string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, objectToSerialize);
            }
        }
    }
}
