using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomRenderers
{
	public partial class MainPage : ContentPage
	{

		protected Dictionary<string,string> samples = new Dictionary<string,string>()
		{
			{ 
				"BoxView with Rounded Corners", 
				"CustomRenderers.BoxViewCustomizations.PageBoxViewRoundedCorners"
			},
			{ 
				"ImageView Drawable", 
				"PageBoxView"
			},
			{ 
				"PickerBindable", 
				"CustomRenderers.Views.Xaml.PagePickerBindable"
			},
		};

		protected Dictionary<string,string> Samples
		{
			get;
			set;
		}

		public MainPage ()
		{
			InitializeComponent ();

			listViewSamples.ItemsSource = Samples = samples;

			return;
		}

		public void OnItemSelected(object sender, ItemTappedEventArgs args_tapped)
		{
			object item = args_tapped.Item;

			KeyValuePair<string, string> kvp = (KeyValuePair<string, string>) item;

			string type_as_string = kvp.Value;

			Type type = Type.GetType(type_as_string);
			Page page = (Page) Activator.CreateInstance(type);

			this.Navigation.PushAsync(page);

			return;

		}

	}
}

