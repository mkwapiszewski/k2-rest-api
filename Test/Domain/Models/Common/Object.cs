using System.Xml.Serialization;

namespace Test.Domain.Models.Common
{
public class Object
{
    [XmlElement("fields")]
    public Fields Fields { get; set; }
}
}
