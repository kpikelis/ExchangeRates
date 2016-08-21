using System.Collections.Generic;

namespace SEB.Services.Models
{
    public class SrvExchangeRates
    {
        public SrvExchangeRates()
        {
            Item = new List<SrvExchangeRatesItem>();
        }
        public List<SrvExchangeRatesItem> Item { get; set; }
    }
}
