using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ControlsViews.Pages
{	
	public partial class PageControlsViewsInXaml : ContentPage
	{	
		public PageControlsViewsInXaml ()
		{
			InitializeComponent ();
		}

		// HACK: needed for iOS which has no back button 
		private void buttonBackPopModal_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PopModalAsync();
		
			return;
		}

		private void buttonControlsViewsSimple_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new Xaml.PageControlsViewsSimple());
		
			return;
		}

		private void buttonListView_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new Xaml.PageListView());
		
			return;
		}

		private void buttonListViewCells_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new Xaml.PageListViewCells());
		
			return;
		}

		private void buttonListViewCellsCustom_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new Xaml.PageListViewCells());
		
			return;
		}

		private void buttonTableView_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PushModalAsync(new Xaml.PageListViewCellsCustom());
		
			return;
		}
	}
}

