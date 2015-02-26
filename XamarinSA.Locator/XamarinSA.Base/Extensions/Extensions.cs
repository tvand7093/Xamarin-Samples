using System;
using System.Collections;

namespace Xamarin.Base.Extensions
{
	public static class Extensions
	{
		public static void Add(this IList list, IEnumerable toAdd){
			foreach (var item in toAdd) {
				list.Add(item);
			}
		}
	}
}

