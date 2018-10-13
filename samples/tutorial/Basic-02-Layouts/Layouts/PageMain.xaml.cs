using System;
using System.Collections.Generic;
using Xamarin.Forms;


using Layouts.LayoutsAdvanced;

namespace Layouts
{	
	public partial class PageMain : ContentPage
	{	
		public PageMain ()
		{
			InitializeComponent ();
		}

		private void buttonLayoutsBasics_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageLayoutsBasics());

			return;
		}

		private void buttonLayoutsAdvanced_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageLayoutsAdvanced());

			return;
		}
	}
}

