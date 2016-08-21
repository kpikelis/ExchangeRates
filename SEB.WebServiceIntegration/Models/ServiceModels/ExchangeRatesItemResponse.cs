using System;
using System.Globalization;
using System.Xml.Serialization;

namespace SEB.WebServiceIntegration.Models.ServiceModels
{
    [XmlRoot("item")]
    public class ExchangeRatesItemResponse
    {
        CultureInfo provider = CultureInfo.InvariantCulture;

        [XmlIgnore]
        public DateTime Date {
            get {
                return DateTime.Parse(DateString);
            }
        }

        [XmlElement("date")]
        public string DateString { get; set; }

        [XmlElement("currency")]
        public string Currency { get; set; }

        [XmlElement("quantity")]
        public int Quantity { get; set; }

        [XmlElement("rate")]
        public decimal Rate { get; set; }

        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
