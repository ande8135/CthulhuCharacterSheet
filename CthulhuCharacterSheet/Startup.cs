using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CthulhuCharacterSheet.Startup))]
namespace CthulhuCharacterSheet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
