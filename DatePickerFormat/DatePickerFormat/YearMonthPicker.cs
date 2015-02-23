using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatePickerFormat
{
	public enum PickerType
	{
		Month, 
		Year
	}

	public sealed class YearMonthPicker : Picker
	{

		private enum Months {
			January,
			February,
			March,
			April,
			May,
			June,
			July,
			August,
			September,
			October,
			November,
			December
		};

		public static readonly BindableProperty SelectedItemProperty =
			BindableProperty.Create<YearMonthPicker, int>(w => w.SelectedItem, default(int), BindingMode.TwoWay);
		public static readonly BindableProperty PickerTypeProperty =
			BindableProperty.Create<YearMonthPicker, PickerType>(w => w.SelectionType, default(PickerType), BindingMode.TwoWay);

		public PickerType SelectionType
		{
			get { return (PickerType)GetValue(PickerTypeProperty); }
			set
			{
				SetValue(PickerTypeProperty, value);
			}
		}
		public int SelectedItem
		{
			get { return (int)GetValue(SelectedItemProperty); }
			set {
				SetValue(SelectedItemProperty, value+1);
				var title = string.Empty;

				switch (SelectionType)
				{
					case PickerType.Month:
						title = GetMonthName(value);
						break;
					default:
						title = value.ToString();
						break;
				}
				Title = title;
			}
		}

		public YearMonthPicker()
		{
			SelectedIndexChanged += CustomDatePicker_SelectedIndexChanged;
		}

		private void CustomDatePicker_SelectedIndexChanged(object sender, EventArgs e)
		{
			var value = Items.ElementAt(base.SelectedIndex);
			SelectedItem = value is string ? (int)Enum.Parse(typeof(Months), value) : int.Parse(value);
		}

		private string GetMonthName(int month) {
			return Enum.GetName(typeof(Months), (Months)month);
		}

		protected override void OnBindingContextChanged()
		{
			Items.Clear();

			if (SelectionType == PickerType.Year)
			{
				//show only years
				for (int i = DateTime.MinValue.Year; i < DateTime.MaxValue.Year + 1; i++)
				{
					Items.Add(i.ToString());
					if (i == SelectedItem)
					{
						SelectedIndex = i - 1;
					}
				}
			}
			else if (SelectionType == PickerType.Month)
			{
				var months = Enum.GetNames(typeof(Months));
				for (int i = 0; i < months.Length; i++)
				{
					Items.Add(months[i]);
					if (i == SelectedItem) SelectedIndex = i - 1;
				}
			}
			
		}
	}
}
