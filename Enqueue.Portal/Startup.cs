using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Enqueue.Portal.Startup))]
namespace Enqueue.Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
