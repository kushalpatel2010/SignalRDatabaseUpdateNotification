using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRDatabaseUpdateNotification.Startup))]
namespace SignalRDatabaseUpdateNotification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
