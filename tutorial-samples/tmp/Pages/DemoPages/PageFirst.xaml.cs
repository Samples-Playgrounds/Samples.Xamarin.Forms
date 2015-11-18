using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPages
{
	public partial class PageFirst : ContentPage
	{
		public PageFirst ()
		{
			InitializeComponent ();

			Title = "First";
			buttonNext.Clicked += ButtonNext_Clicked;
			buttonModal.Clicked += ButtonModal_Clicked;
		}

		void ButtonModal_Clicked (object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new PageModal());
		}

		void ButtonNext_Clicked (object sender, EventArgs e)
		{
			this.Navigation.PushAsync(new PageSecond());
		}
	}
}

