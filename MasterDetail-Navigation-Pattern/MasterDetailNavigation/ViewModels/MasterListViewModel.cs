using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetailNavigation.ViewModels
{
	public class MasterListViewModel : BindableObject
	{
		MasterListItemViewModel selectedItem;
		public MasterListItemViewModel Selected {
			get { return selectedItem; }
			set {
				selectedItem = value;
				OnPropertyChanged ("Selected");
			}
		}

		public List<MasterListItemViewModel> Selections { get; private set; }

		public MasterListViewModel ()
		{
			Selections = new List<MasterListItemViewModel> {
				new MasterListItemViewModel () {
					Id = MasterListItemViewModel.HomePageId,
					Title = "Home Page"
				},
				new MasterListItemViewModel () {
					Id = MasterListItemViewModel.MoreContentId,
					Title = "More Content Page"
				},
				new MasterListItemViewModel () {
					Id = MasterListItemViewModel.LogoutId,
					Title = "Log out"
				}
			};

			MessagingCenter.Subscribe<MasterListItemViewModel> (this,
				MasterListItemViewModel.SelectedMessage,
				(selection) => {
					Selected = null;
				});
		}
	}
}

