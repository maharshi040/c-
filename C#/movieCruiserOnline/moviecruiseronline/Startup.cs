using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(moviecruiseronline.Startup))]
namespace moviecruiseronline
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
