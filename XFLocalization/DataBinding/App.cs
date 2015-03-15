using System;
using Xamarin.Forms;
using DataBinding.Views;
using DataBinding.Localization;

namespace DataBinding
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new MainPage ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
			//set language on app start
			SetupLanguage();
		}

		public static void SetupLanguage(){
			//set the language for translations. We don't need to do that for win phones
			//since it happens automagically.
			if (Device.OS != TargetPlatform.WinPhone) {
				//use the dependency service to get the current language.
				AppResources.Culture = DependencyService.Get<ILocalizable>().GetCurrentCultureInfo();
			}
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
			//reset the language in case the user changed languages 
			SetupLanguage();
		}
	}
}

