using System.Collections.Generic;
using System.Xml.Serialization;

namespace SEB.WebServiceIntegration.Models.ServiceModels
{
    [XmlRoot("ExchangeRates")]
    public class ExchangeRatesResponse
    {
        [XmlElement("item")]
        public List<ExchangeRatesItemResponse> Item { get; set; }
    }
}
