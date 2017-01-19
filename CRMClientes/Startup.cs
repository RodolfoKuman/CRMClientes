using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRMClientes.Startup))]
namespace CRMClientes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
