using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailNavigation.Pages
{
	public partial class MoreContentPage : ContentPage
	{
		public MoreContentPage ()
		{
			NavigationPage.SetHasBackButton (this, false);

			InitializeComponent ();
		}
	}
}

