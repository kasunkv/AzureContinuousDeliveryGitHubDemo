using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureContinuousDeliveryGitHubDemo.Startup))]
namespace AzureContinuousDeliveryGitHubDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
