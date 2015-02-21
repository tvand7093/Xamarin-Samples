using System;

namespace DataBinding.ViewModels
{
	public class MainPageViewModel : BaseViewModel
	{
		private string message;
		public string Message {
			get { return message; }
			set {
				message = value;
				//notify the view that this has changed so it knows to refresh.
				OnPropertyChanged ("Message");
			}
		}
		public MainPageViewModel ()
		{
			Message = "Hello world!";
		}
	}
}

