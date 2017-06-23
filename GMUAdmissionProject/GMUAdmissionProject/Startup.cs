using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GMUAdmissionProject.Startup))]
namespace GMUAdmissionProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
