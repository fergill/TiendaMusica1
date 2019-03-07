using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TiendaMusica1.Startup))]
namespace TiendaMusica1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
