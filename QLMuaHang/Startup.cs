using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLMuaHang.Startup))]
namespace QLMuaHang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
