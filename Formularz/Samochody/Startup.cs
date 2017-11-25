using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Samochody.Startup))]
namespace Samochody
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
