using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ControlsView.MapView.Views.XAML
{
	public partial class PageMapSimple : ContentPage
	{
		public PageMapSimple ()
		{
			InitializeComponent ();


			var position = new Position(37.79762, -122.40181);
			Map.MoveToRegion(new MapSpan(position, 0.01, 0.01));
			Map.Pins.Add(new Pin
			{
			    Label = "Xamarin",
			    Position = position
			});


			return;
		}
	}
}

