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

		private string title;
		public string Title { 
			get { return title; }
			set {
				title = value;
				OnPropertyChanged ("Title");
			}
		}

		public TestViewModel ()
		{
			Title = "Foo";

			Device.StartTimer (new TimeSpan(0, 0, 5), () => {
				Title = "Bar";
				return true;
			});
		}
	}
}

