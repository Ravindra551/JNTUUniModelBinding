using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JNTUUniModelBinding.Startup))]
namespace JNTUUniModelBinding
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
