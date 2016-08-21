using System;
using SEB.WebServiceIntegration.Configuration;
using SEB.WebServiceIntegration.Models;

namespace SEB.WeServiceIntegrationTests
{
    public static class WebServiceIntegrationTestData
    {
        public static ExchangeRatesConfiguration GetWebServiceIntegrationConfiguration()
        {
            return new ExchangeRatesConfiguration
            {
                Url = "http://webservices.lb.lt/ExchangeRates/ExchangeRates.asmx/",
                UserName = "",
                Password = ""
            };
        }

        public static IntgrExchangeRatesInput GetExchangeRatesByDateInput()
        {
            return new IntgrExchangeRatesInput {
                Date = new DateTime(2013,01,01)
            };
        }
    }
}
