using SEB.WebServiceIntegration.Models;
using SEB.WebServiceIntegration.Models.ServiceModels;
using System.Collections.Generic;

namespace SEB.WebServiceIntegration.Mappings
{
    public static class ExchangeRatesItemResponseToExchangeRatesItemMapper
    {
        public static List<IntgrExchangeRatesItem> MapToExchangeRatesItems(this List<ExchangeRatesItemResponse> exchangeRatesItemResponse)
        {
            var items = new List<IntgrExchangeRatesItem>();
            exchangeRatesItemResponse.ForEach(itm => items.Add(itm.MapToExchangeRatesItem()));
            return items;
        }

        public static IntgrExchangeRatesItem MapToExchangeRatesItem(this ExchangeRatesItemResponse exchangeRatesItemResponse)
        {
            return MapToExchangeRatesItem(exchangeRatesItemResponse, new IntgrExchangeRatesItem());
        }

        public static IntgrExchangeRatesItem MapToExchangeRatesItem(this ExchangeRatesItemResponse exchangeRatesItemResponse, IntgrExchangeRatesItem exchangeRatesItem)
        {
            exchangeRatesItem.Currency = exchangeRatesItemResponse.Currency;
            exchangeRatesItem.Date = exchangeRatesItemResponse.Date;
            exchangeRatesItem.Quantity = exchangeRatesItemResponse.Quantity;
            exchangeRatesItem.Rate = exchangeRatesItemResponse.Rate;
            exchangeRatesItem.Unit = exchangeRatesItemResponse.Unit;
            return exchangeRatesItem;
        }
    }
}
