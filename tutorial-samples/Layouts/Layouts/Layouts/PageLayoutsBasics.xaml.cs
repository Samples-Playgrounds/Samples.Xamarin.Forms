using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Layouts
{	
	public partial class PageLayoutsBasics : ContentPage
	{	
		public PageLayoutsBasics ()
		{
			InitializeComponent ();
		}

		private void buttonContentView_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new Pages.PageWithContentView());

			return;
		}

		private void buttonContentViewAsUserControl_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new Pages.PageWithContentViewAsUserControl());

			return;
		}

		private void buttonFrame_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new Pages.PageWithFrame());

			return;
		}

		private void buttonScrollView_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new Pages.PageWithScrollView());

			return;
		}

		private void buttonAbsoluteLayout_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new Pages.PageWithAbsoluteLayout());

			return;
		}

		private void buttonGrid_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new Pages.PageWithGrid());

			return;
		}

		private void buttonRelativeLayout_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new Pages.PageWithRelativeLayout());

			return;
		}

		private void buttonStackLayout_Clicked(object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new Pages.PageWithStackLayout());

			return;
		}



	}
}

