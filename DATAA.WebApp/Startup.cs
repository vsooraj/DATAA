using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DATAA.WebApp.Startup))]
namespace DATAA.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
