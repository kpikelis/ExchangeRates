using System;

namespace SEB.Web.Areas.ExchangeRates.Models
{
    public class ExchangeRatesItemViewModel
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal RateBefore { get; set; }
        public decimal RateDifference { get; set; }
        public string Unit { get; set; }
    }
}
