using System;

namespace SEB.Services.Models
{
    public class SrvExchangeRatesItem
    {
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal RateBefore { get; set; }
        public decimal RateDifference {
            get {
                return Rate - RateBefore;
            }
        }
        public string Unit { get; set; }
    }
}
