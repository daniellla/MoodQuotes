using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoodQuotes.Startup))]
namespace MoodQuotes
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
