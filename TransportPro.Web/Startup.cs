using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TransportPro.Web.Startup))]
namespace TransportPro.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
