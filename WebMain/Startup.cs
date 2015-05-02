using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMain.Startup))]
namespace WebMain
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
