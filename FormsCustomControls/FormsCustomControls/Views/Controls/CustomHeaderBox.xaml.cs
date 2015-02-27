using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Diagnostics;
using System.Linq;

namespace FormsCustomControls.Controls
{
	public partial class CustomHeaderBox : ContentView
	{

		private const string LeftTitlePropertyName = "LeftTitle";
		private const string RightTitlePropertyName = "RightTitle";

		public static BindableProperty LeftTitleProperty = 
			BindableProperty.Create<CustomHeaderBox, string>(ctrl => ctrl.LeftTitle,
				defaultValue: string.Empty,
				defaultBindingMode: BindingMode.TwoWay,
				propertyChanging: (bindable, oldValue, newValue) => {
					HandleProrpertyChanging<string>(LeftTitlePropertyName, bindable,
						oldValue, newValue);
				});

		public static BindableProperty RightTitleProperty = 
			BindableProperty.Create<CustomHeaderBox, string>(ctrl => ctrl.RightTitle,
				defaultValue: string.Empty,
				defaultBindingMode: BindingMode.TwoWay,
				propertyChanging: (bindable, oldValue, newValue) => {
					HandleProrpertyChanging<string>(RightTitlePropertyName, bindable,
						oldValue, newValue);
				});


		/// <summary>
		/// Used to change the view according to the property changed
		/// </summary>
		private static void HandleProrpertyChanging<T>(string property, BindableObject bindable,
			T oldValue, T newValue){
			//first grab our control
			var ctrl = (CustomHeaderBox)bindable;

			//now check to see which property changed and set view properties accordingly.
			if (property.CompareTo (LeftTitlePropertyName) == 0) {
				ctrl.LeftTitle = newValue as string;
			}
			if (property.CompareTo (RightTitlePropertyName) == 0) {
				ctrl.RightTitle = newValue.ToString();
			}
		}

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

