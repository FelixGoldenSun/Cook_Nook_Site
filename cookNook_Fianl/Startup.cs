using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cookNook_Fianl.Startup))]
namespace cookNook_Fianl
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
