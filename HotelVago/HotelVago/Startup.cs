using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelVago.Startup))]
namespace HotelVago
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
