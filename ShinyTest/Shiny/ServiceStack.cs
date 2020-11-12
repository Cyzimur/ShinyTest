using System;
using Prism.Ioc;
using Shiny;
using Shiny.Notifications;

namespace ShinyTest.Shiny
{
    public class ServiceStack : IShinyStartupTask
    {
        public ServiceStack(IContainerExtension container, INotificationManager notificationManager)
        {
            Container = container;
            NotificationManager = notificationManager;
        }

        public IContainerExtension Container { get; }
        public INotificationManager NotificationManager { get; }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterRequiredTypes();
        }

        public void Start()
        {
            RegisterTypes(Container);
            NotificationManager.Send("ShinyTest", "App Started!");
        }
    }
}
