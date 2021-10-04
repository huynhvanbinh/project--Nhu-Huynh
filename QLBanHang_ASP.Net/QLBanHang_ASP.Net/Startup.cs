using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLBanHang_ASP.Net.Startup))]
namespace QLBanHang_ASP.Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
