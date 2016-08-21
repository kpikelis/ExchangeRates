using SEB.Services.Models;
using SEB.Web.Areas.ExchangeRates.Models;

namespace SEB.Web.Mappings
{
    public static class SrvExchangeRatesToExchangeRatesViewModelMapper
    {
        public static ExchangeRatesViewModel MapToExchangeRatesViewModel(this SrvExchangeRates srvExchangeRates)
        {
            return MapToExchangeRatesViewModel(srvExchangeRates, new ExchangeRatesViewModel());
        }

        public static ExchangeRatesViewModel MapToExchangeRatesViewModel(this SrvExchangeRates srvExchangeRates, ExchangeRatesViewModel exchangeRatesViewModel)
        {
            exchangeRatesViewModel.Items = srvExchangeRates.Item.MapToExchangeRatesItemViewModels();
            return exchangeRatesViewModel;
        }
    }
}
