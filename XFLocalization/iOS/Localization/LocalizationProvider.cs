using System;
using DataBinding.Localization;
using Foundation;
using Xamarin.Forms;

[assembly:Dependency(typeof(DataBinding.iOS.Localization.LocalizationProvider))]

namespace DataBinding.iOS.Localization
{
	public class LocalizationProvider : ILocalizable
	{
		#region ILocalizable implementation

		//METHOD CODE PROVIDED BY Xamarin
		//http://developer.xamarin.com/guides/cross-platform/xamarin-forms/localization/#iOS_Application_Project
		public System.Globalization.CultureInfo GetCurrentCultureInfo ()
		{
			//grab the current device language, or english as a default.
			var netLanguage = "en";
			if (NSLocale.PreferredLanguages.Length > 0) {
				var pref = NSLocale.PreferredLanguages [0];
				netLanguage = pref.Replace ("_", "-"); // turns pt_BR into pt-BR
			}
			return new System.Globalization.CultureInfo(netLanguage);
		}

		#endregion

		public LocalizationProvider ()
		{
		}
	}
}

