using System;
using System.Globalization;

namespace DataBinding.Localization
{
	public interface ILocalizable
	{
		CultureInfo GetCurrentCultureInfo ();
	}
}

