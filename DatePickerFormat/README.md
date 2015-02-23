# A simple month/year picker control.

Provides a simple way to have a single selection for either a month or a year. Currently, you cannot slim that down from the default DatePicker provided by Xamarin.Forms.

### Usage

After importing the namespace into your XAML file, you can use the following to add it to your view:

```
<yournamespace:YearMonthPicker SelectedItem="{Binding Data}" PickerType="{Binding Type}"/>
```
Where the Data property is an integer, and the Type is a PickerType bound from a view model.
