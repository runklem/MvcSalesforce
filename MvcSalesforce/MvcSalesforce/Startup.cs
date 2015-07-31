using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSalesforce.Startup))]
namespace MvcSalesforce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
