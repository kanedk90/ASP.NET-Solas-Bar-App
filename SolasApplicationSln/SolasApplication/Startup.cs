using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SolasApplication.Startup))]
namespace SolasApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
