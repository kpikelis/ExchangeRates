using SEB.Services.Models;
using System;

namespace SEB.Services.Interfaces
{
    public interface IExchangeRatesService
    {
        SrvExchangeRates GetExchangeRates(SrvExchangeRatesInput input);

        SrvExchangeRates GetExchangeRatesByDate(DateTime date);
    }
}
