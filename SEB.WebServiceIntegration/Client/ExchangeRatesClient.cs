using SEB.WebServiceIntegration.Client.Interfaces;
using SEB.WebServiceIntegration.Configuration;
using SEB.WebServiceIntegration.Models;
using SEB.WebServiceIntegration.Models.ServiceModels;
using SEB.WebServiceIntegration.ServiceModels;
using ServiceStack;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SEB.WebServiceIntegration.Client
{
    public class ExchangeRatesClient : IExchangeRatesClient
    {
        private JsonServiceClient _client;
        private readonly ExchangeRatesConfiguration _configuration;

        public ExchangeRatesClient(IExchangeRatesConfigurationProvider configurationProvider)
        {
            if (configurationProvider == null)
                throw new ArgumentNullException(nameof(configurationProvider));

            _configuration = configurationProvider.GetConfiguration();
        }

        public JsonServiceClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = GetNewClient();
                }

                return _client;
            }
        }

        public JsonServiceClient GetNewClient()
        {
            var client = new JsonServiceClient(_configuration.Url);

            if (_configuration.TimeoutMilliseconds.HasValue)
            {
                client.Timeout = TimeSpan.FromMilliseconds(_configuration.TimeoutMilliseconds.Value);
            }

            return client;
        }

        private string getErrorMessage(string xml)
        {
            using (var reader = new StringReader(xml))
            {
                try
                {
                    var error = (string)new XmlSerializer(typeof(string), new XmlRootAttribute { ElementName = "message" }).Deserialize(reader);
                    return error;
                }
                catch (Exception ex) { return null; }
            }
        }
        private T DeserializeXml<T>(string xml)
        {
            T obj;
            using (var reader = new StringReader(xml))
            {
                obj = (T)new XmlSerializer(typeof(T)).Deserialize(reader);
            }
            return obj;
        }

        private async Task<T> CallServiceAsync<T>(string httpMethod, string serviceMethodName, object request)
        {
            var response = Client.Send<string>(httpMethod, serviceMethodName, request);
            var errorMessage = getErrorMessage(response);
            if (!string.IsNullOrEmpty(errorMessage))
                throw new Exception(errorMessage);
            return DeserializeXml<T>(response);
        }

        public async Task<ExchangeRatesResponse> GetExchangeRatesByDate(ExchangeRatesRequest request)
        {
            return await CallServiceAsync<ExchangeRatesResponse>("GET", IntgrExchangeRatesServiceNames.GetExchangeRatesByDate, request);
        }

    }
}