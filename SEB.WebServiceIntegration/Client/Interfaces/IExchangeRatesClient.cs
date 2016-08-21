using System.Threading.Tasks;
using SEB.WebServiceIntegration.ServiceModels;
using SEB.WebServiceIntegration.Models.ServiceModels;

namespace SEB.WebServiceIntegration.Client.Interfaces
{
    public interface IExchangeRatesClient
    {
        Task<ExchangeRatesResponse> GetExchangeRatesByDate(ExchangeRatesRequest request);
    }
}
