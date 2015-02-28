using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;
using System.Linq;

namespace FormsCustomControls.Controls
{
	public partial class CustomHeaderBox : ContentView
	{

		public static BindableProperty LeftTitleProperty = 
			BindableProperty.Create<CustomHeaderBox, string>(ctrl => ctrl.LeftTitle,
				defaultValue: string.Empty,
				defaultBindingMode: BindingMode.TwoWay,
				propertyChanging: (bindable, oldValue, newValue) => {
					var ctrl = (CustomHeaderBox)bindable;
					ctrl.LeftTitle = newValue;
				});

		public static BindableProperty RightTitleProperty = 
			BindableProperty.Create<CustomHeaderBox, string>(ctrl => ctrl.RightTitle,
				defaultValue: string.Empty,
				defaultBindingMode: BindingMode.TwoWay,
				propertyChanging: (bindable, oldValue, newValue) => {
					var ctrl = (CustomHeaderBox)bindable;
					ctrl.RightTitle = newValue;
				});
					
		public string LeftTitle {
			get { return (string)GetValue(LeftTitleProperty); }
			set { 
				SetValue (LeftTitleProperty, value);
				LeftTitleLabel.Text = value;
			}
		}

		public string RightTitle {
			get { return (string)GetValue(RightTitleProperty); }
			set { 
				SetValue (RightTitleProperty, value);
				RightTitleLabel.Text = value;
			}
		}

		public CustomHeaderBox ()
		{
			InitializeComponent ();
		}
	}
}

