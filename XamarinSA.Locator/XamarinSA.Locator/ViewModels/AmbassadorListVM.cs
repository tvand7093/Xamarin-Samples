using System;
using System.Collections.ObjectModel;
using XamarinSA.Locator.Models;
using Xamarin.Base;
using Xamarin.Base.ViewModels;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Base.Extensions;
using XamarinSA.Locator.Views;

namespace XamarinSA.Locator.ViewModels
{
	public class AmbassadorListVM : BaseListViewModel<Ambassador>
	{

		public AmbassadorListVM ()
		{
			var assembly = typeof(AmbassadorListVM).GetTypeInfo ().Assembly;
			var stream = assembly.GetManifestResourceStream ("XamarinSA.Locator.Data.Ambassadors.json");
			using (var reader = new StreamReader (stream)) {
				reader.ReadToEndAsync ().ContinueWith((task) => {
					if(!String.IsNullOrEmpty(task.Result)){
						//here result will be a json string of ambassadors
						var loc = JsonConvert.DeserializeObject<List<Ambassador>>(task.Result);
						Items.Add(loc);
					}
				}, TaskScheduler.FromCurrentSynchronizationContext());
			}

			SelectionChangedCommand = new Command (async () => {
				if(SelectedItem != null){
					await Navigation.PushAsync(new AmbassadorDetails(){
						BindingContext = new AmbassadorDetailsVM(SelectedItem)
					});
					SelectedItem = null;
				}
			});

		}
	}
}
	