using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AHGEventReg.Startup))]
namespace AHGEventReg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
