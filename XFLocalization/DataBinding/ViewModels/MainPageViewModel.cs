using System;
using System.Windows.Input;
using Xamarin.Forms;
using DataBinding.Localization;

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

		private string name;
		public string Name {
			get { return name; }
			set {
				name = value;
				//notify the view that this has changed so it knows to refresh.
				OnPropertyChanged ("Name");
				//since the value changed, we need to also trigger the valid input
				OnPropertyChanged("HasValidInput");
			}
		}

		//the command to use for clicks
		//notice we don't do the "OnPropertyChanged since
		//the button command should never change.
		public ICommand ShowNameCommand { get; private set;}

		//this is used to determine if the button can be clicked.
		public bool HasValidInput { get { return !String.IsNullOrEmpty (Name); } }


		public MainPageViewModel ()
		{
			//create the action that gets called on the button click
			ShowNameCommand = new Command (() => {
				//set the message to show the data typed into the text editor
				//note: the Name property is now filling data from the UI!

				//Localization note: you can access the language translations using the AppResources class.
				Message = AppResources.NameLabel + Name;
			});
		}
	}
}

