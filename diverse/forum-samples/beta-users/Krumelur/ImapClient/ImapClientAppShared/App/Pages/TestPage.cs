using System;
using Xamarin.QuickUI;
using System.ComponentModel;

namespace ImapClientAppShared
{
	public class TestPage : ContentPage
	{
		public TestPage () : base()
		{
			var button = new Button {
				Text = "Click me!"
			};
			button.Activated += (object sender, EventArgs e) => {
			};

			var layout = new StackLayout { 
				Orientation = StackLayout.StackOrientation.Vertical
			}.WithChildren (button);

			this.Content = layout;
		}
	}
}

