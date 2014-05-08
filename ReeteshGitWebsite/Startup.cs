using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReeteshGitWebsite.Startup))]
namespace ReeteshGitWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
