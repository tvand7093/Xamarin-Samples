using System;
using Xamarin.Forms;
using XamarinSA.Locator.Misc;

namespace XamarinSA.Locator.Views
{
	public class StyledNavigationPage : NavigationPage
	{
		public StyledNavigationPage (Page content) : base (content)
		{
			BarTextColor = Color.White;
			BarBackgroundColor = Color.FromHex (ColorStyles.XamarinLightBlue);
		}
	}
}

