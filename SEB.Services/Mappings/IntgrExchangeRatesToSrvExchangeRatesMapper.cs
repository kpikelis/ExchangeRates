using SEB.Services.Models;
using SEB.WebServiceIntegration.Models;

namespace SEB.Services.Mappings
{
    public static class IntgrExchangeRatesToSrvExchangeRatesMapper
    {
        public static SrvExchangeRates MapToSrvExchangeRates(this IntgrExchangeRates intgrExchangeRates)
        {
            return MapToSrvExchangeRates(intgrExchangeRates, new SrvExchangeRates());
        }

        public static SrvExchangeRates MapToSrvExchangeRates(this IntgrExchangeRates intgrExchangeRates, SrvExchangeRates srvExchangeRates)
        {
            srvExchangeRates.Item = intgrExchangeRates.Item.MapToSrvExchangeRatesItems();
            return srvExchangeRates;
        }
    }
}
