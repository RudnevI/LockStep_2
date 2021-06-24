using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LockStep.Startup))]
namespace LockStep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
