using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETBSA.Presentation.Front.Web2.Startup))]
namespace ETBSA.Presentation.Front.Web2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
