using System;
using Xamarin.Forms.Platform.iOS;
using FormsCustomControls.Controls;
using Xamarin.Forms;
using FormsCustomControls.iOS.Renderers;
using UIKit;

[assembly: ExportRenderer((typeof(CustomHeaderBox)), typeof(CustomHeaderBoxRenderer))]
namespace FormsCustomControls.iOS.Renderers
{
	public class CustomHeaderBoxRenderer : ViewRenderer<CustomHeaderBox, UIView>
	{
		protected override void OnElementChanged (ElementChangedEventArgs<CustomHeaderBox> e)
		{
			base.OnElementChanged (e);

			//Set border color, width, and radius (make rounded corners)
			Layer.BorderColor = UIColor.LightGray.CGColor;
			Layer.BorderWidth = 1;
			Layer.CornerRadius = 30;
		}

		public CustomHeaderBoxRenderer ()
		{

		}
	}
}

