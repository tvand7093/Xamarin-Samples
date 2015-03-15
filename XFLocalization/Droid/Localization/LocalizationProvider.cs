using System;
using Xamarin.Forms;
using DataBinding.Localization;


[assembly:Dependency(typeof(DataBinding.Droid.Localization.LocalizationProvider))]
namespace DataBinding.Droid.Localization
{
	public class LocalizationProvider : ILocalizable
	{
		#region ILocalizable implementation

		//METHOD CODE PROVIDED BY Xamarin
		//http://developer.xamarin.com/guides/cross-platform/xamarin-forms/localization/#Android_Application_Project
		public System.Globalization.CultureInfo GetCurrentCultureInfo ()
		{
			var androidLocale = Java.Util.Locale.Default;
			var netLanguage = androidLocale.ToString().Replace ("_", "-"); // turns pt_BR into pt-BR
			return new System.Globalization.CultureInfo(netLanguage);
		}

		#endregion

		public LocalizationProvider ()
		{
		}
	}
}

