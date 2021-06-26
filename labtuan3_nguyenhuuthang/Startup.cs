using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(labtuan3_nguyenhuuthang.Startup))]
namespace labtuan3_nguyenhuuthang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
