using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarrersStack.Web.Startup))]
namespace CarrersStack.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
