using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cooperchip.AulaChagas.Web.Startup))]
namespace Cooperchip.AulaChagas.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
