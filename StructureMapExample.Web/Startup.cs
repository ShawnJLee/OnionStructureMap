using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StructureMapExample.Web.Startup))]
namespace StructureMapExample.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
