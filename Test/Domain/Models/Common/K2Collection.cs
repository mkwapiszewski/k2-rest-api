using System.Xml.Serialization;

namespace Test.Domain.Models.Common
{
    [XmlRoot("collection")]
    public class K2Collection
    {
        [XmlElement("object")]
        public List<Object> Objects { get; set; }

        public IEnumerable<string> GetListValues()
        {
            return Objects.SelectMany(x => x.Fields.FieldList.Select(y => y.Value));
        }
    }
}
