using System;
using Xamarin.Forms.Platform.iOS;
using XamarinSA.Locator.Views.Cells;
using XamarinSA.Locator.iOS.Renderers;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using XamarinSA.Locator.Misc;


[assembly: Xamarin.Forms.ExportRenderer(typeof(AmbassadorCell), typeof(AmbassadorCellRenderer))]
namespace XamarinSA.Locator.iOS.Renderers
{
	public class AmbassadorCellRenderer : ImageCellRenderer
	{
		public override UIKit.UITableViewCell GetCell (Xamarin.Forms.Cell item, UIKit.UITableViewCell reusableCell, UIKit.UITableView tv)
		{
			var cell = base.GetCell (item, reusableCell, tv);

			cell.Accessory = UIKit.UITableViewCellAccessory.DisclosureIndicator;

			//set blue border for image
			cell.ImageView.Layer.BorderColor = Color.White.ToCGColor();
			cell.ImageView.Layer.BorderWidth = 1;
			cell.BackgroundColor = Color.FromHex (ColorStyles.XamarinDark).ToUIColor ();

			return cell;
		}
		public AmbassadorCellRenderer ()
		{

		}
	}
}

