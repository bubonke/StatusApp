using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatusApp.Startup))]
namespace StatusApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
