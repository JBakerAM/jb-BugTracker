using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jb_BugTracker.Startup))]
namespace jb_BugTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
