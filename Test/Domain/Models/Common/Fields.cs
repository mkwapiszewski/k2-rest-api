using System.Xml.Serialization;

namespace Test.Domain.Models.Common
{
public class Fields
{
    [XmlElement("field")]
    public List<Field> FieldList { get; set; }
}
}
