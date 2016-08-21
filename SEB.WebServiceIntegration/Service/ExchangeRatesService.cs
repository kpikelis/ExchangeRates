using SEB.WebServiceIntegration.Client.Interfaces;
using SEB.WebServiceIntegration.Models;
using SEB.WebServiceIntegration.Mappings;
using SEB.WebServiceIntegration.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace SEB.WebServiceIntegration.Service
{
    public class ExchangeRatesService : IExchangeRatesService
    {
        private readonly IExchangeRatesClient _client;

        public ExchangeRatesService(IExchangeRatesClient client)
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));
            _client = client;
        }

        public async Task<IntgrExchangeRates> GetExchangeRatesByDate(IntgrExchangeRatesInput exchangeRatesInput)
        {
            var response = await _client.GetExchangeRatesByDate(exchangeRatesInput.MapToExchangeRatesRequest());
            return response.MapToExchangeRates();
        }
    }
}
