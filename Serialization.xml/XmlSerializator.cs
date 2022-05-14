using System.IO;
using System.Xml.Serialization;

namespace Serialization.xml
{
    public class XmlSerializator
    {
        public T Deserialize<T>(string filePath)
            where T : class
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            // десериализуем объект
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return xmlSerializer.Deserialize(fs) as T;
            }
        }

        public void Serialize<T>(object objectToSerialize, string filePath)
            where T: class
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, objectToSerialize);
            }
        }
    }
}
