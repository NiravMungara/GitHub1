using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AWSPublishTest.Startup))]
namespace AWSPublishTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
