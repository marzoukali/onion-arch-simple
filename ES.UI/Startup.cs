using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ES.UI.Startup))]
namespace ES.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
