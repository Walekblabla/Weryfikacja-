using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectCar.Startup))]
namespace ProjectCar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
