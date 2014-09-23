using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;

namespace ControlsViews
{
	public partial class PageControlsViewsSimpleInCode : ContentPage
	{
		public PageControlsViewsSimpleInCode()
		{

			Content = Grid();

			// HACk: mc++ Accomodate iPhone status bar.
			Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 10);

			return;
		}


		private Grid Grid()
		{
			Label labelData = new Label
									{
										Text = "Data:",
									};
			Entry entryData = new Entry
									{
										Placeholder = "data"
									};
			Button buttonDataSave = new Button
									{
										Text = "Send"
									};


			Grid grid =
					new Grid
					{
						VerticalOptions = LayoutOptions.FillAndExpand,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						RowDefinitions = 
							{
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
								new RowDefinition 
								{
									Height = new GridLength (1, GridUnitType.Star)
								},
							},
						ColumnDefinitions = 
							{
								new ColumnDefinition 
								{
									Width = new GridLength (1, GridUnitType.Star)
								},
								new ColumnDefinition 
								{
									Width = new GridLength (1, GridUnitType.Star)
								},
								new ColumnDefinition 
								{
									Width = new GridLength (1, GridUnitType.Star)
								},
							},

						// add controls to Grid.Childrern
						Children =
							{
								{
									labelData, 
									0, 0
								},
								{
									entryData,
									1, 0
								},
								{
									buttonDataSave,
									2, 0
								},
								//{BuildPalletFrame(), 0, 1},
								//{new ContentView {
								//    Content = BuildDrawingFrame(),
								//    Padding = new Thickness(10, 0, 0, 0),
								//    HorizontalOptions = LayoutOptions.FillAndExpand,
								//    VerticalOptions = LayoutOptions.FillAndExpand
								//}, 1, 1}
							}

					};

			//------------------------------------------------------------------------
			//TODO: mc++ Box
			//------------------------------------------------------------------------

			return grid;
		}
	}
}
