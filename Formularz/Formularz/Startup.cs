using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Formularz.Startup))]
namespace Formularz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
