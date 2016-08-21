using NLog;
using SEB.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using IIntegrationInterfaces = SEB.WebServiceIntegration.Service.Interfaces;
using IntegrationServices = SEB.WebServiceIntegration.Service;
using IntegrationClients = SEB.WebServiceIntegration.Client;
using IntegrationConfigurations = SEB.WebServiceIntegration.Configuration;
using SEB.Services.Models;
using SEB.Services.Mappings;

namespace SEB.Services
{
    public class ExchangeRatesService : IExchangeRatesService
    {
        private readonly IIntegrationInterfaces.IExchangeRatesService _integrationExchangeRatesService;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();


        public ExchangeRatesService()
        {
            _integrationExchangeRatesService = new IntegrationServices.ExchangeRatesService(
                new IntegrationClients.ExchangeRatesClient(new IntegrationConfigurations.ExchangeRatesConfigurationProvider()));
        }

        public SrvExchangeRates GetExchangeRatesByDate(DateTime date)
        {
            var exchangeByDate = GetExchangeRates(new SrvExchangeRatesInput { Date = date });
            var exchangeDayBefore = GetExchangeRates(new SrvExchangeRatesInput { Date = date.AddDays(-1) });

            return GetExchangeRates(exchangeByDate, exchangeDayBefore);
        }

        public SrvExchangeRates GetExchangeRates(SrvExchangeRatesInput input)
        {
            var srvExchangeRates = new SrvExchangeRates();
            try
            {
                _logger.Info($"Started getting Exchange Rates (Date={input.Date.ToString()})");

                var exchangeRatesByDate = _integrationExchangeRatesService.GetExchangeRatesByDate(input.MapToIntgrExchangeRatesInput()).GetAwaiter().GetResult();

                exchangeRatesByDate.MapToSrvExchangeRates(srvExchangeRates);

                _logger.Info($"Finished getting Exchange Rates (Date={input.Date.ToString()})");
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                throw ex;
            }
            return srvExchangeRates;
        }

        private SrvExchangeRates GetExchangeRates(SrvExchangeRates exchangeByDate, SrvExchangeRates exchangeDayBefore)
        {
            foreach (var exchangeRate in exchangeByDate.Item)
            {
                var exchangeRateDayBefore = exchangeDayBefore.Item.SingleOrDefault(itmDayBef =>
                    itmDayBef.Currency == exchangeRate.Currency &&
                    itmDayBef.Quantity == exchangeRate.Quantity &&
                    itmDayBef.Unit == exchangeRate.Unit);
                exchangeRate.RateBefore = exchangeRateDayBefore != null ? exchangeRateDayBefore.Rate : 0;
            }
            exchangeByDate.Item = exchangeByDate.Item.OrderByDescending(itm => itm.RateDifference).ToList();
            return exchangeByDate;
        }
    }
}
