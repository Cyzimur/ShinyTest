using System;
using Microsoft.Extensions.DependencyInjection;
using Shiny;
using Shiny.Logging;
using Shiny.Prism;
using Prism.DryIoc;
using ShinyTest.Shiny.Delegates;

namespace ShinyTest.Shiny
{
    public class AppStartup : PrismStartup
    {
        public AppStartup() : base(PrismContainerExtension.Current)
        {
        }

        protected override void ConfigureServices(IServiceCollection services)
        {
            Log.UseConsole();
            Log.UseDebug();

            services.UseNotifications<ShinyTestNotificationDelegate>(true);

            //Startup Task
            services.AddSingleton<ServiceStack>();
        }
    }
}
