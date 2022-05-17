using System;
using System.Runtime.Serialization;

namespace Serialization.OwnBinary
{
    [Serializable]
    public class Cat : ISerializable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Cat() { }

        public Cat(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue(nameof(Name), typeof(string));
            Age = (int)info.GetValue(nameof(Age), typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue(nameof(Name), Name, Name.GetType());
            info.AddValue(nameof(Age), Age, Age.GetType());
        }
    }
}
