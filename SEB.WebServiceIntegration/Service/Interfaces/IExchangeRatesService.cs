using SEB.WebServiceIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEB.WebServiceIntegration.Service.Interfaces
{
    public interface IExchangeRatesService
    {
        Task<IntgrExchangeRates> GetExchangeRatesByDate(IntgrExchangeRatesInput exchangeRatesInput);
    }
}
