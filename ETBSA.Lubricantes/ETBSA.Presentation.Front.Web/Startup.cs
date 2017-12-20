using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETBSA.Presentation.Front.Web.Startup))]
namespace ETBSA.Presentation.Front.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
