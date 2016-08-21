using SEB.Services.Interfaces;
using SEB.Web.Areas.ExchangeRates.Models;
using SEB.Web.Mappings;
using System;
using System.Web.Mvc;

namespace SEB.Web.Areas.ExchangeRates.Controllers
{
    public class ExchangeRatesController : Controller
    {
        private readonly IExchangeRatesService _exchangeRatesService;

        public ExchangeRatesController(IExchangeRatesService exchangeRatesService)
        {
            _exchangeRatesService = exchangeRatesService;
        }

        public JsonResult GetExchangeRates(DateTime date)
        {
            var rates = _exchangeRatesService.GetExchangeRatesByDate(date).MapToExchangeRatesViewModel();
            return Json(rates, JsonRequestBehavior.AllowGet);
        }

    }
}