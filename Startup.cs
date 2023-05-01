using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FBC_SIMIRIT.Startup))]
namespace FBC_SIMIRIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
