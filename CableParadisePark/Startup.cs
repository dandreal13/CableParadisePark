using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CableParadisePark.Startup))]
namespace CableParadisePark
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
