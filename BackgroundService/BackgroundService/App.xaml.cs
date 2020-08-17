using BackgroundService.Services;
using Matcha.BackgroundService;
using Xamarin.Forms;

namespace BackgroundService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            StartBackgroundService();
        }

        protected override void OnSleep()
        {
           
        }

        protected override void OnResume()
        {
            
        }

        private static void StartBackgroundService()
        {
            BackgroundAggregatorService.Add(() => new PeriodicTask(10));

            // Running the periodic task in the background
            BackgroundAggregatorService.StartBackgroundService();
        }
    }
}
