using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopTwo.Startup))]
namespace MyShopTwo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
