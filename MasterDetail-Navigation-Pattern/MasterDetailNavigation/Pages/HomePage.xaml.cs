using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailNavigation.Pages
{
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			NavigationPage.SetHasBackButton (this, false);
			InitializeComponent ();
		}
	}
}

