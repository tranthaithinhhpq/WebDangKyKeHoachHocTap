using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDangKyKeHoachHocTap.Startup))]
namespace WebDangKyKeHoachHocTap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
