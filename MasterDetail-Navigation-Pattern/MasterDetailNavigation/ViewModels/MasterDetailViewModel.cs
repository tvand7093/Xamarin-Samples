using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using MasterDetailNavigation.Pages;

namespace MasterDetailNavigation.ViewModels
{
	public class MasterDetailViewModel : BindableObject
	{
		bool isFlyoutOpen;
		public bool IsFlyoutOpen {
			get { return isFlyoutOpen; } 
			set {
				isFlyoutOpen = value;
				OnPropertyChanged ("IsFlyoutOpen");
			}
		}

		bool canShowFlyout;
		public bool CanShowFlyout {
			get { return canShowFlyout; } 
			set {
				canShowFlyout = value;
				OnPropertyChanged ("CanShowFlyout");
			}
		}

		public MasterDetailViewModel ()
		{
			MessagingCenter.Subscribe<LoginViewModel> (this,
				MasterListItemViewModel.ShowHomePage,
				async (login) => {
					CanShowFlyout = true;
					await ChangePages(MasterListItemViewModel.HomePageId);
				});
			
			MessagingCenter.Subscribe<MasterListItemViewModel> (this,
				MasterListItemViewModel.SelectedMessage,
				async (selection) => {
					await ChangePages(selection.Id);
				});
		}

		async Task SwapPages(Page toDisplay){
			var nav = (Application.Current.MainPage as MasterDetailPage).Detail.Navigation;
			var stack = nav.NavigationStack;

			await nav.PushAsync (toDisplay);

			if (stack.Count > 2) {
				for (int i = 1; i <= stack.Count - 2; i++) {
					nav.RemovePage (stack [i]);
				}
			}
		}

		async Task ChangePages(Guid selectedId){
			IsFlyoutOpen = false;

			if (selectedId == MasterListItemViewModel.HomePageId) {
				//show home page
				await SwapPages(new HomePage());
			} else if (selectedId == MasterListItemViewModel.MoreContentId) {
				//show more content
				await SwapPages(new MoreContentPage());
			} else if (selectedId == MasterListItemViewModel.LogoutId) {
				//logout
				CanShowFlyout = false;
				await (Application.Current.MainPage as MasterDetailPage).Detail.Navigation.PopToRootAsync();
			}
		}
	}
}

