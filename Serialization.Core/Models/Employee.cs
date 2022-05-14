using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization.Core.Models
{
    [Serializable]
    public class Employee
    {
        [JsonPropertyName("empName")]
        [XmlElement(ElementName = "empName")]
        public string EmpoyeeName { get; set; }
    }
}
