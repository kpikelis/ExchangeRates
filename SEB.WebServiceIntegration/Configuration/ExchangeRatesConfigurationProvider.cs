using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEB.WebServiceIntegration.Configuration
{
    public class ExchangeRatesConfigurationProvider : IExchangeRatesConfigurationProvider
    {
        const string UrlSetting = "ExchangeRatesConfiguration:Url";
        const string UserNameSetting = "ExchangeRatesConfiguration:UserName";
        const string PasswordSetting = "ExchangeRatesConfiguration:Password";
        const string TimeoutMillisecondsSetting = "ExchangeRatesConfiguration:TimeoutMilliseconds";

        public ExchangeRatesConfiguration GetConfiguration()
        {
            var configuration = new ExchangeRatesConfiguration();

            configuration.Url = ConfigurationManager.AppSettings[UrlSetting];
            configuration.UserName = ConfigurationManager.AppSettings[UserNameSetting];
            configuration.Password = ConfigurationManager.AppSettings[PasswordSetting];

            int timeout;

            if (int.TryParse(ConfigurationManager.AppSettings[TimeoutMillisecondsSetting], out timeout))
            {
                configuration.TimeoutMilliseconds = timeout;
            }

            return configuration;
        }
    }
}
