using System.Xml.Serialization;

namespace Test.Domain.Helpers
{
    public static class XmlHelper
{
    public static T DeserializeXml<T>(string xml)
    {
        var serializer = new XmlSerializer(typeof(T));
        using StringReader reader = new StringReader(xml);
        return (T)serializer.Deserialize(reader);
    }
}
}
