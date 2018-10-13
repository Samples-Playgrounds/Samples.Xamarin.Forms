using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ControlsView.MapView.Views
{
	public partial class PageMain : ContentPage
	{
		public PageMain ()
		{
			InitializeComponent ();
		}

		public void OnItemSelected(object sender, ItemTappedEventArgs args_tapped)
		{
			object item = args_tapped.Item;

			KeyValuePair<string, string> kvp = (KeyValuePair<string, string>) item;

			string type_as_string = kvp.Value;

			Type type = Type.GetType(type_as_string);
			Page page = 
					(Page) Activator.CreateInstance(type)
					// HolisticWare.Mobile.UI.XamarinForms.Activator.CreateElement<Page>(type_as_string)
					;

			this.Navigation.PushAsync(page);

			return;

		}
	}
}

