using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace MasterDetailNavigation.ViewModels
{
	public class MasterListItemViewModel
	{
		public static readonly Guid HomePageId = Guid.NewGuid();
		public static readonly Guid MoreContentId = Guid.NewGuid();
		public static readonly Guid LogoutId = Guid.NewGuid ();

		public const string SelectedMessage = "SelectedMasterItem";
		public const string ShowHomePage = "ShowHomePage";

		public Guid Id { get; set; } 

		public string Title { get; set; }

		public ICommand Selected { get; private set; }

		public MasterListItemViewModel ()
		{
			Selected = new Command(() => {
				MessagingCenter.Send<MasterListItemViewModel>(this, SelectedMessage);
			});
		}
	}
}

