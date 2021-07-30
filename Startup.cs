using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_FIRST_PROJECT.Startup))]
namespace MVC_FIRST_PROJECT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
