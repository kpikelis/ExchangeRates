using SEB.Services.Models;
using SEB.Web.Areas.ExchangeRates.Models;
using System.Collections.Generic;

namespace SEB.Web.Mappings
{
    public static class SrvExchangeRatesItemToExchangeRatesItemViewModelMapper
    {
        public static List<ExchangeRatesItemViewModel> MapToExchangeRatesItemViewModels(this List<SrvExchangeRatesItem> srvExchangeRatesItemList)
        {
            var items = new List<ExchangeRatesItemViewModel>();
            srvExchangeRatesItemList.ForEach(itm => items.Add(itm.MapToExchangeRatesItemViewModel()));
            return items;
        }

        public static ExchangeRatesItemViewModel MapToExchangeRatesItemViewModel(this SrvExchangeRatesItem srvExchangeRatesItem)
        {
            return MapToExchangeRatesItemViewModel(srvExchangeRatesItem, new ExchangeRatesItemViewModel());
        }

        public static ExchangeRatesItemViewModel MapToExchangeRatesItemViewModel(this SrvExchangeRatesItem srvExchangeRatesItem, ExchangeRatesItemViewModel exchangeRatesItemViewModel)
        {
            exchangeRatesItemViewModel.Currency = srvExchangeRatesItem.Currency;
            exchangeRatesItemViewModel.Date = srvExchangeRatesItem.Date;
            exchangeRatesItemViewModel.Quantity = srvExchangeRatesItem.Quantity;
            exchangeRatesItemViewModel.Rate = srvExchangeRatesItem.Rate;
            exchangeRatesItemViewModel.Unit = srvExchangeRatesItem.Unit;
            exchangeRatesItemViewModel.RateBefore = srvExchangeRatesItem.RateBefore;
            exchangeRatesItemViewModel.RateDifference = srvExchangeRatesItem.RateDifference;
            return exchangeRatesItemViewModel;
        }
    }
}
