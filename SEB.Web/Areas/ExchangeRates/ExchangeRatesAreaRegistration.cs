using System.Web.Mvc;

namespace SEB.Web.Areas.ExchangeRates
{
    public class ExchangeRatesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ExchangeRates";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ExchangeRates_default",
                "ExchangeRates/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}