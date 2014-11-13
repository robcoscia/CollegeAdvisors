using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeAdvisors.Startup))]
namespace CollegeAdvisors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
