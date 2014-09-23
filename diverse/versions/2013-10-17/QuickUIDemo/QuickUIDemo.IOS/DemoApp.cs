using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.QuickUI;

namespace QuickUIDemo
{
	public static class DemoApp
	{
		public static Page GetMainPage ()
		{
			var result = new NavigationPage (new WelcomePage ());
			return result;
		}
	}

	public class DataPage : ContentPage
	{
		public DataPage ()
		{
			Title = "Person List";
			var itemList = new[] {
				new { Name = "Jason Smith", Title = "Engineer" },
				new { Name = "Seth Rosetter", Title = "Jr. Engineer" },
				new { Name = "Eric M", Title = "Engineer" },
				new { Name = "David S", Title = "Designer" },
				new { Name = "Vinny D", Title = "Designer" },
				new { Name = "Nat Friedman", Title = "CEO" },
				new { Name = "Miguel de Icaza", Title = "CTO" },
			};

			var listView = new ListView {
				ItemSource = itemList,
				Template = new CellTemplate (typeof (TextCell))
			};

			listView.Template.SetBinding (TextCell.TextProperty, new Binding ("Name"));
			listView.Template.SetBinding (TextCell.DetailProperty, new Binding ("Title"));

			Content = listView;
		}
	}

	public class WelcomePage : ContentPage
	{
		StackLayout mainLayout;
		Entry usernameEntry;
		Entry passwordEntry;
		Button loginButton;

		public WelcomePage ()
		{
			Title = "QuickUI Demo";
			Content = mainLayout = new StackLayout {
				Padding = new Thickness(20, 20, 20, 100),
				Spacing = 10,
				Orientation = StackLayout.StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.Center
			};

			mainLayout.Add (new Label {
				Text = "Welcome to the QuickUI Demo App!",
				XAlign = TextAlignment.Center
			});

			mainLayout.Add (usernameEntry = new Entry { Placeholder = "Username" });
			mainLayout.Add (passwordEntry = new Entry {
				Placeholder = "Password",
				Password = true
			});
			mainLayout.Add (loginButton = new Button {
				Text = "Login",
				IsEnabled = false
			});

			usernameEntry.ValueChanged += (sender, arg) => loginButton.IsEnabled = LoginAvailable ();
			passwordEntry.ValueChanged += (sender, arg) => loginButton.IsEnabled = LoginAvailable ();

			loginButton.Activated += (sender, args) => {
				if (LoginAvailable ()) {
					Navigation.Push (new DataPage ());
				}
			};
		}

		bool LoginAvailable ()
		{
			return !string.IsNullOrWhiteSpace (usernameEntry.Text) && !string.IsNullOrWhiteSpace (passwordEntry.Text);
		}
	}
}
