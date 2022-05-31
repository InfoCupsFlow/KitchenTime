using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace KitchenTimeXamarin
{
	public partial class App : Application
	{
		public App()
		{
			// Registre Syncfusion licence
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjQ4MTU0QDMyMzAyZTMxMmUzMEE5QzFxWTJmUERPVFllTTE5NmozcHlQdDkySHh4TjhQZGlMQUExcXBsbTg9");


			InitializeComponent();

			MainPage = new AppShell();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}