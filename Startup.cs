using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompanyWebForms.Startup))]
namespace CompanyWebForms
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
        }
    }
}
