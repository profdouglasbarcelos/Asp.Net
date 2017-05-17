using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WingtipToysMVC.Startup))]
namespace WingtipToysMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
