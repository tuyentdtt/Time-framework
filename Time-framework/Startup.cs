using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Time_framework.Startup))]
namespace Time_framework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
