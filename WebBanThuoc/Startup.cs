using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBanThuoc.Startup))]
namespace WebBanThuoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
