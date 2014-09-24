using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ControlsViews.Pages.Xaml
{	
	public partial class PageControlsViewsSimple : ContentPage
	{	
		public PageControlsViewsSimple ()
		{
			InitializeComponent ();
		}

		// HACK: needed for iOS which has no back button 
		private void buttonBackPopModal_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PopModalAsync();
		
			return;
		}

	}
}

