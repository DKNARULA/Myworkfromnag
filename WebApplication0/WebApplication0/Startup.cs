using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication0.Startup))]
namespace WebApplication0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
