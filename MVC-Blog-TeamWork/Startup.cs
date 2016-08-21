using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Blog_TeamWork.Startup))]
namespace MVC_Blog_TeamWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
