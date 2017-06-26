using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkTestTourPackage.Startup))]
namespace WorkTestTourPackage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
