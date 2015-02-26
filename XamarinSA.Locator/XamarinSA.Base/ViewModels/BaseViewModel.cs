using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Xamarin.Base.ViewModels
{
	public abstract class BaseViewModel : INotifyPropertyChanged
	{
		public bool IsBusy {
			get { return Application.Current.MainPage.IsBusy; }
			set { Application.Current.MainPage.IsBusy = value; }
		}

		public INavigation Navigation {
			get { return Application.Current.MainPage.Navigation; }
		}
			
		#region Property Changed Implementation

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
	}
}

