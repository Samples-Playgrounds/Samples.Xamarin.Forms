using System;

using Xamarin.Forms;

using System.Reflection;

namespace ControlsViews.Pages.Code
{
	public class PageControlsViewsEnumerated : ContentPage
	{
		public PageControlsViewsEnumerated ()
		{
			// HACk: mc++ Accomodate iPhone status bar.
			Padding = new Thickness (10, Device.OnPlatform (20, 0, 0), 10, 10);

			StackLayout layout = new StackLayout () {
				BackgroundColor = Color.Yellow,
				Padding = new Thickness (
					20, 
					Device.OnPlatform<double> (40, 20, 20),
					20,
					20
				)
			};
			/*
			Assembly assembly_core = typeof(StackLayout).Assembly;
			System.Type type_searched_for = typeof(View);

			foreach 
				(	
					Type type in assembly_core.GetTypes()
											.Where
											(
												t => type_searched_for.IsAssignableFrom(t)
											)
				)
			{
				layout.Children.Add
					(
						new Label()
						{
							Text = type.Name
						}
					);
			}
			*/

			this.Content =  new ScrollView()
			{
				Content = layout
			};

			return;
		}
			
	}
}

