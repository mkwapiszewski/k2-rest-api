using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Test.Domain.Helpers;
using Test.Domain.Models.Common;

namespace Test.Domain.Models.Order
{
    public class CreateOrderRequest
    {
        public string Name { get; set; }

        [JsonPropertyName("OrderList")]
        public string _OrderList { get; set; }

        [JsonIgnore]
        public K2Collection OrderListParsed => XmlHelper.DeserializeXml<K2Collection>(_OrderList);
    }
}
