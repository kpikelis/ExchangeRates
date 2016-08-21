using SEB.WebServiceIntegration.Models;
using SEB.WebServiceIntegration.Models.ServiceModels;

namespace SEB.WebServiceIntegration.Mappings
{
    public static class ExchangeRatesResponseToExchangeRatesMapper
    {
        public static IntgrExchangeRates MapToExchangeRates(this ExchangeRatesResponse exchangeRatesResponse)
        {
            return MapToExchangeRates(exchangeRatesResponse, new IntgrExchangeRates());
        }

        public static IntgrExchangeRates MapToExchangeRates(this ExchangeRatesResponse exchangeRatesResponse, IntgrExchangeRates exchangeRates)
        {
            exchangeRates.Item = exchangeRatesResponse.Item.MapToExchangeRatesItems();
            return exchangeRates;
        }
    }
}
