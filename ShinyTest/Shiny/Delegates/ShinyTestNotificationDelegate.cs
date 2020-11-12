using System;
using System.Threading.Tasks;
using Shiny.Notifications;

namespace ShinyTest.Shiny.Delegates
{
    public class ShinyTestNotificationDelegate : INotificationDelegate
    {
        public Task OnEntry(NotificationResponse response)
        {
            return Task.CompletedTask;
        }

        public Task OnReceived(Notification notification)
        {
            return Task.CompletedTask;
        }
    }
}
