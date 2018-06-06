using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula0506_Autenticacao.Startup))]
namespace Aula0506_Autenticacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
