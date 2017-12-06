using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Taxi.Web.Startup))]
namespace Taxi.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
