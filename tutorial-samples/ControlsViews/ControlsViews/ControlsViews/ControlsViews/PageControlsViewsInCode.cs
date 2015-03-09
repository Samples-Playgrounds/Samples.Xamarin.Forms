using System;

using Xamarin.Forms;

namespace ControlsViews
{
	public class PageControlsViewsInCode : ContentPage
	{
		public PageControlsViewsInCode ()
		{
			Content = StackLayout();

			// HACK: mc++ OnPlatform - iOS specific Accomodate iPhone status bar.
			// Platform Specific uncomment this part to see the difference!
			// check XAML sample PageControlsViewsInXaml.xaml
			// Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 10);

			return;
		}

		private StackLayout StackLayout()
		{

			Button buttonControlsViewsSimple = new Button()
			{
				Text = "Controls/Views Simple (Common)"
			};
			buttonControlsViewsSimple.Clicked += buttonControlsViewsSimple_Clicked;

			StackLayout stack_layout = new StackLayout()
			{
				Orientation = StackOrientation.Vertical
			};

			stack_layout.Children.Add(buttonControlsViewsSimple);

			return stack_layout;
		}


		private async void buttonControlsViewsSimple_Clicked(object sender, EventArgs e)
		{
			ContentPage content_page = new ControlsViews.Pages.Code.PageControlsViewsSimple();


			/*
			Page navigation_page = new NavigationPage(content_page);
			await Navigation.PushAsync(navigation_page);
			*/

			this.Navigation.PushModalAsync(content_page);

			return;
		}


	}
}

