using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoPages
{
	public partial class PageSecond : ContentPage
	{
		public PageSecond ()
		{
			InitializeComponent ();

			buttonNext.Clicked += ButtonNext_Clicked;
			buttonPrevious.Clicked += ButtonPrevious_Clicked;
		}

		void ButtonPrevious_Clicked (object sender, EventArgs e)
		{
			this.Navigation.PopAsync();

		}

		void ButtonNext_Clicked (object sender, EventArgs e)
		{
			this.Navigation.PushAsync(new PageSecond());
		}

	}
}

