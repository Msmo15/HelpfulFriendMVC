using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelpfulFriendMVC.Startup))]
namespace HelpfulFriendMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
