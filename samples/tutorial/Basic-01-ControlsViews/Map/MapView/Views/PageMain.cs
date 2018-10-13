using System;

using Xamarin.Forms;

namespace ControlsView.MapView.Views
{
	public class PageMain : ContentPage
	{
		public PageMain ()
		{
			Content = new StackLayout { 
				Children = {
						new Label {
							Text = "Hello ContentPage"
						}
				}
			};
		}
	}
}


