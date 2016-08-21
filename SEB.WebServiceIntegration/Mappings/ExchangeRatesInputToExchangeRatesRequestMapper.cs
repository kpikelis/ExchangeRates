using SEB.WebServiceIntegration.Models;
using SEB.WebServiceIntegration.ServiceModels;

namespace SEB.WebServiceIntegration.Mappings
{
    public static class ExchangeRatesInputToExchangeRatesRequestMapper
    {
        public static ExchangeRatesRequest MapToExchangeRatesRequest(this IntgrExchangeRatesInput exchangeRatesInput)
        {
            return MapToExchangeRatesRequest(exchangeRatesInput, new ExchangeRatesRequest());
        }

        public static ExchangeRatesRequest MapToExchangeRatesRequest(this IntgrExchangeRatesInput exchangeRatesInput, ExchangeRatesRequest exchangeRatesRequest)
        {
            exchangeRatesRequest.Date = exchangeRatesInput.Date.ToString();
            return exchangeRatesRequest;
        }
    }
}
