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

		private int year;
		public int Data {
			get { return year; }
			set {
				year = value;
				OnPropertyChanged ("Data");
			}
		}

		private string month;
		public string Month
		{
			get { return month; }
			set
			{
				month = value;
				OnPropertyChanged("Month");
			}
		}

		public PickerType Type
		{
			get { return PickerType.Month; }
		}

		public ViewModel ()
		{
			Data = DateTime.Now.Month;
		}
	}
}

