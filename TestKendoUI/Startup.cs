using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestKendoUI.Startup))]
namespace TestKendoUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
