using Autofac;
using SEB.Services.Interfaces;

namespace SEB.Services.Infrastructure
{
    public class ServicesDependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ExchangeRatesService>().As<IExchangeRatesService>().InstancePerRequest();
        }
    }
}
