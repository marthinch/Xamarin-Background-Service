using Matcha.BackgroundService;
using Plugin.LocalNotifications;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BackgroundService.Services
{
    public class PeriodicTask : IPeriodicTask
    {
        public PeriodicTask(int interval)
        {
            Interval = TimeSpan.FromSeconds(interval);
        }

        public TimeSpan Interval { get; set; }

        public Task<bool> StartJob()
        {
            CrossLocalNotifications.Current.Show("Test local notification", "This notification is running from background service");
            return Task.FromResult(true);
        }
    }
}
