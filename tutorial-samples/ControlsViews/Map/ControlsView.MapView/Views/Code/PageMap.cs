using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ControlsView.MapView.Views.Code
{
	public partial class PageMap : Xamarin.Forms.ContentPage
	{
		public PageMap()
		{
			Map map = 
			new Map
				(
				MapSpan.FromCenterAndRadius
							(
								// new Position(45.493743,15.554813),  // Karlovac
								new Position(46.3899013,16.44409),	// Cakovec
								Distance.FromMiles(0.5)
							)
				)
			{
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			StackLayout stack = new StackLayout 
			{
				Spacing = 0 
			};
			stack.Children.Add(map);

			Content = stack;

			return;
		}
	}
}
