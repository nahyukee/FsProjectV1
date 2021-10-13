using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FsProject.Startup))]
namespace FsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
