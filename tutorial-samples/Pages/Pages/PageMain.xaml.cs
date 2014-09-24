using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Pages
{	
	public partial class PageMain : ContentPage
	{	
		public PageMain ()
		{
			InitializeComponent ();
		}

		private void buttonContentPage_Clicked (object o, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageContentPage());

			return;
		}

		private void buttonNavigationPage_Clicked (object o, EventArgs ea)
		{
			//this.Navigation.PushModalAsync(new PageNavigationPage());

			return;
		}

		private void buttonTabbedPage_Clicked (object o, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageTabbedPage());

			return;
		}

		private void buttonCarouselPage_Clicked (object o, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageCarouselPage());

			return;
		}

		private void buttonMasterDetailPage_Clicked (object o, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new MasterDetailPage());

			return;
		}

	}
}

