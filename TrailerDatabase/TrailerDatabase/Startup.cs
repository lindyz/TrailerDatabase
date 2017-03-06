using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrailerDatabase.Startup))]
namespace TrailerDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
