using SEB.Services.Models;
using SEB.WebServiceIntegration.Models;
using System.Collections.Generic;

namespace SEB.Services.Mappings
{
    public static class IntgrExchangeRatesItemToSrvExchangeRatesItemMapper
    {
        public static List<SrvExchangeRatesItem> MapToSrvExchangeRatesItems(this List<IntgrExchangeRatesItem> intgrExchangeRatesItemList)
        {
            var items = new List<SrvExchangeRatesItem>();
            intgrExchangeRatesItemList.ForEach(itm => items.Add(itm.MapToSrvExchangeRatesItem()));
            return items;
        }

        public static SrvExchangeRatesItem MapToSrvExchangeRatesItem(this IntgrExchangeRatesItem intgrExchangeRatesItem)
        {
            return MapToSrvExchangeRatesItem(intgrExchangeRatesItem, new SrvExchangeRatesItem());
        }

        public static SrvExchangeRatesItem MapToSrvExchangeRatesItem(this IntgrExchangeRatesItem intgrExchangeRatesItem, SrvExchangeRatesItem srvExchangeRatesItem)
        {
            srvExchangeRatesItem.Currency = intgrExchangeRatesItem.Currency;
            srvExchangeRatesItem.Date = intgrExchangeRatesItem.Date;
            srvExchangeRatesItem.Quantity = intgrExchangeRatesItem.Quantity;
            srvExchangeRatesItem.Rate = intgrExchangeRatesItem.Rate;
            srvExchangeRatesItem.Unit = intgrExchangeRatesItem.Unit;
            return srvExchangeRatesItem;
        }
    }
}
