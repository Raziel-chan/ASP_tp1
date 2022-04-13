using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PAUM_ASP_tp1.Startup))]
namespace PAUM_ASP_tp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
