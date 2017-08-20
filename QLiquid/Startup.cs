using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLiquid.Startup))]
namespace QLiquid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
