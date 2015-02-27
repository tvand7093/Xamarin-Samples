using System;
using Xamarin.Forms.Platform.Android;
using FormsCustomControls.Controls;
using Android.Graphics;
using Xamarin.Forms;
using FormsCustomControls.Droid.Renderers;

[assembly: ExportRenderer((typeof(CustomHeaderBox)), typeof(CustomHeaderBoxRenderer))]
namespace FormsCustomControls.Droid.Renderers
{
	public class CustomHeaderBoxRenderer : ViewRenderer<CustomHeaderBox, global::Android.Views.View>
	{
		public override int SolidColor {
			get {
				return 1;
			}
		}
//		public override void Draw (Canvas canvas)
//		{
//			base.Draw (canvas);
//			var width = (int)1 * Resources.DisplayMetrics.Density;
//			var radius = 30 * Resources.DisplayMetrics.Density;
//			base.draw
//
////			DrawStroke(canvas, rect, radius, width);
////			DrawText(canvas, rect, label.Text);
//		}

		public CustomHeaderBoxRenderer ()
		{

		}
	}
}

