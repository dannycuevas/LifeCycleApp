using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCLifecycle.Startup))]
namespace MVCLifecycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
