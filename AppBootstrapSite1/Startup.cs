using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppBootstrapSite1.Startup))]
namespace AppBootstrapSite1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
