using System;
using Xamarin.Forms.Platform.iOS;
using XamarinSA.Locator.iOS.Renderers;
using XamarinSA.Locator.Views;


[assembly: Xamarin.Forms.ExportRenderer(typeof(StyledListView), typeof(StyledListViewRenderer))]

namespace XamarinSA.Locator.iOS.Renderers
{
	public class StyledListViewRenderer : ListViewRenderer
	{
		protected override void OnElementPropertyChanged (object sender,
			System.ComponentModel.PropertyChangedEventArgs e)
		{

			base.OnElementPropertyChanged (sender, e);
		}

		public StyledListViewRenderer ()
		{

		}
	}
}

