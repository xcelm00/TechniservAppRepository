using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechniservApp.Startup))]
namespace TechniservApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
