using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FundamentosMVC.Startup))]
namespace FundamentosMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
