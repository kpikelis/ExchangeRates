using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using SEB.Services.Infrastructure;
using System.Threading.Tasks;
using System.Reflection;

namespace SEB.Web.Infrastructure
{
    public class DependencyRegistrar
    {
        public static IContainer ContainerMvc { get; private set; }

        public void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            OnConfigure(builder);

            if (ContainerMvc == null)
            {
                ContainerMvc = builder.Build();
            }
            else
            {
                builder.Update(ContainerMvc);
            }
            DependencyResolver.SetResolver(new AutofacDependencyResolver(ContainerMvc));

        }

        protected virtual void OnConfigure(ContainerBuilder builder)
        {
            builder.RegisterModule(new ServicesDependencyModule());
        }
    }
}

