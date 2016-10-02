using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlexandraViolin.Startup))]
namespace AlexandraViolin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
