using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPages
{
	public partial class PageModal : ContentPage
	{
		public PageModal ()
		{
			InitializeComponent ();

			buttonDismiss.Clicked += ButtonDismiss_Clicked;
			buttonNext.Clicked += async (object sender, EventArgs e) => 
			{
				this.Navigation.PushAsync(new PageSecond());

			};
		}

		void ButtonDismiss_Clicked (object sender, EventArgs e)
		{
			this.Navigation.PopModalAsync();
		}
	}
}

