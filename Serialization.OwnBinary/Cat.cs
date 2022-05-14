using System;
using System.Runtime.Serialization;

namespace Serialization.OwnBinary
{
    [Serializable]
    public class Cat : ISerializable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue(nameof(Name), Name);
            info.AddValue(nameof(Age), Age);
        }
    }
}
