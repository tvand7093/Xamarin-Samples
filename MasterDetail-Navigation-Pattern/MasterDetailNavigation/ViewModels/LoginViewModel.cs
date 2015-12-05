using System;
using System.Windows.Input;
using Xamarin.Forms;
using MasterDetailNavigation.Pages;

namespace MasterDetailNavigation.ViewModels
{
	public class LoginViewModel
	{
		public ICommand Login { get; private set; } 

		public LoginViewModel ()
		{
			Login = new Command (() => {
				MessagingCenter.Send<LoginViewModel>(this, MasterListItemViewModel.ShowHomePage);
			});
		}
	}
}

