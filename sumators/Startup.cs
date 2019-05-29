using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sumators.Startup))]
namespace sumators
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
