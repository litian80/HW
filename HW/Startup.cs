using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW.Startup))]
namespace HW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
