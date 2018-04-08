using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EZLeapWeb.Startup))]
namespace EZLeapWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
