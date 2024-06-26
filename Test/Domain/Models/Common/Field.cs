using System.Xml.Serialization;

namespace Test.Domain.Models.Common
{
public class Field
{
    [XmlElement("value")]
    public string Value { get; set; }
}
}
