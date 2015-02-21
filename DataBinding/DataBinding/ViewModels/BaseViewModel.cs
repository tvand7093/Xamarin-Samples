using System;
using System.ComponentModel;

namespace DataBinding.ViewModels
{
	public abstract class BaseViewModel : INotifyPropertyChanged
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
	}
}

