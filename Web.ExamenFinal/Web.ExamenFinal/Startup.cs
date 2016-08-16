using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.ExamenFinal.Startup))]
namespace Web.ExamenFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
