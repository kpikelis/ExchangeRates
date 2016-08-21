using SEB.Services.Models;
using SEB.WebServiceIntegration.Models;

namespace SEB.Services.Mappings
{
    public static class SrvExchangeRatesInputToIntgrExchangeRatesInputMapper
    {
        public static IntgrExchangeRatesInput MapToIntgrExchangeRatesInput(this SrvExchangeRatesInput srvExchangeRatesInput)
        {
            return MapToIntgrExchangeRatesInput(srvExchangeRatesInput, new IntgrExchangeRatesInput());
        }

        public static IntgrExchangeRatesInput MapToIntgrExchangeRatesInput(this SrvExchangeRatesInput srvExchangeRatesInput, IntgrExchangeRatesInput intgrExchangeRatesInput)
        {
            intgrExchangeRatesInput.Date = srvExchangeRatesInput.Date;
            return intgrExchangeRatesInput;
        }
    }
}
