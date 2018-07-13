using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Review_Site_Project.Startup))]
namespace MVC_Review_Site_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
