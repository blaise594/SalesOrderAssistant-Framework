using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesOrderAssistant.Startup))]
namespace SalesOrderAssistant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
