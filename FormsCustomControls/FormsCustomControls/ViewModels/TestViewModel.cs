using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace FormsCustomControls.ViewModels
{
	public class TestViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}

		private string left;
		public string Left { 
			get { return left; }
			set {
				left = value;
				OnPropertyChanged ("Left");
			}
		}

		private string right;
		public string Right { 
			get { return right; }
			set {
				right = value;
				OnPropertyChanged ("Right");
			}
		}

		public TestViewModel ()
		{
			Left = "Foo";
			Right = "Bar";

			Device.StartTimer (new TimeSpan(0, 0, 5), () => {
				Left = "Bar";
				Right = "Foo";
				return true;
			});
		}
	}
}

