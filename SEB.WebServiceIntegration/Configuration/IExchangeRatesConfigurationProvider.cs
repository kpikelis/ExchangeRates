using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEB.WebServiceIntegration.Configuration
{
    public interface IExchangeRatesConfigurationProvider
    {
        ExchangeRatesConfiguration GetConfiguration();
    }
}
