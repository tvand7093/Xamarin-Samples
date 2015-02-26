using System;
using System.Collections.ObjectModel;
using Xamarin.Base.Extensions;
using Xamarin.Forms;
using System.Windows.Input;

namespace Xamarin.Base.ViewModels
{
	public class BaseListViewModel<T> : BaseViewModel where T : class
	{

		private ObservableCollection<T> items;
		public ObservableCollection<T> Items {
			get { return items; }
			set {
				items.Clear ();
				items.Add (value);
				OnPropertyChanged ("Items");
			}
		}

		private T selectedItem;
		public T SelectedItem {
			get { return selectedItem; }
			set {
				selectedItem = value;
				OnPropertyChanged ("SelectedItem");
				if (SelectionChangedCommand != null && SelectionChangedCommand.CanExecute(null)) {
					SelectionChangedCommand.Execute (null);
				}
			}
		}

		public ICommand SelectionChangedCommand { get; protected set; }

		public BaseListViewModel ()
		{
			items = new ObservableCollection<T> ();
		}
	}
}

