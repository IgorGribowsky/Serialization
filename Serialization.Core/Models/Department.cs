using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization.Core.Models
{
    [Serializable]
    public  class Department
    {
        [XmlElement(ElementName = "depName")]
        [JsonPropertyName("depName")]
        public string DepartmentName { get; set; }

        [XmlElement(ElementName = "employees")]
        [JsonPropertyName("employees")]
        public List<Employee> Employees { get; set; }
    }
}
