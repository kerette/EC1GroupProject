using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EC1GroupProject.Startup))]
namespace EC1GroupProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
