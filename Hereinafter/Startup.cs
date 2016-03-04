using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hereinafter.Startup))]
namespace Hereinafter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
