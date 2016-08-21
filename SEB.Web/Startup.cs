using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEB.Web.Startup))]
namespace SEB.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
