using System;
using Xamarin.Forms;
using XamarinSA.Locator.Views;
using XamarinSA.Locator.ViewModels;

namespace XamarinSA.Locator
{
	public class App : Application
	{
		public App ()
		{
			MainPage = new StyledNavigationPage (new AmbassadorList ());
		}

		protected override void OnResume ()
		{
			base.OnResume ();
		}

		protected override void OnSleep ()
		{
			base.OnSleep ();
		}

		protected override void OnStart ()
		{
			base.OnStart ();
		}
	}
}

