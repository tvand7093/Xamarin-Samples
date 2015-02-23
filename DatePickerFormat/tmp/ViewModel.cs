using System;
using System.ComponentModel;

namespace DatePickerFormat
{
	public class ViewModel : INotifyPropertyChanged
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

		private DateTime dt;
		public DateTime Date {
			get { return dt; }
			set {
				dt = value;
				OnPropertyChanged ("Date");
			}
		}

		public ViewModel ()
		{
			dt = DateTime.Now;
		}
	}
}

