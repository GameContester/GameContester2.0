using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameContester.Web.Startup))]
namespace GameContester.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
