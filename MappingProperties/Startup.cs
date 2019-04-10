using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MappingProperties.Startup))]
namespace MappingProperties
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
