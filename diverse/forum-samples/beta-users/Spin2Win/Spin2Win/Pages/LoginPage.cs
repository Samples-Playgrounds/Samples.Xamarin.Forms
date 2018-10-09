using System;
using Xamarin.QuickUI;

namespace Spin2Win
{
	public class LoginButton : View 
	{

	}

	public class SpinButtonPressedArgs : EventArgs
	{
		public string Name { get; private set; }
		public string Email { get; private set; }
		public string Company { get; private set; }
		public bool CompletedAzureChallenge { get; private set; }

		public SpinButtonPressedArgs (string name, string email, string company, bool completedChallenge)
		{
			Name = name;
			Email = email;
			Company = company;
			CompletedAzureChallenge = completedChallenge;
		}
	}

	public class LoginPage : ContentPage
	{
		Entry nameEntry;
		Entry emailEntry;
		Entry companyEntry;
		Switch challengeSwitch;

		public event EventHandler<SpinButtonPressedArgs> SpinButtonPressed;
		bool isPhone;

		public LoginPage ()
		{
			BackgroundColor = Color.FromRgb (57, 57, 57);

			isPhone = Device.Idiom == TargetIdiom.Phone;

			var logo = new Image {
				Source = "hexagon.png",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				IsTappable = true
			};

			logo.Tapped += (s, e) => {
				System.Diagnostics.Debug.WriteLine ("Show Backup");
				var hiddenUsersPage = new HiddenUsersPage (HiddenViewType.BackupLog);
				Navigation.Push (hiddenUsersPage);
			};

			if (isPhone) {
				logo.WidthRequest = 175;
				logo.HeightRequest = 175;
			} else {
				logo.WidthRequest = 250;
				logo.HeightRequest = 250;
			}

			var winPrizeLabel = new Label {
				Text = "Win a Xamarin Prize",
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				TextColor = Color.White,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.Center,
				HeightRequest = 100,
				IsTappable = true
			};

			winPrizeLabel.Tapped += (s, e) => {
				System.Diagnostics.Debug.WriteLine ("Show Sync");
				var hiddenUsersPage = new HiddenUsersPage (HiddenViewType.SyncView);
				Navigation.Push (hiddenUsersPage);
			};

			if (isPhone) {
				Device.OnPlatform (iOS: () => winPrizeLabel.Font = Font.FontForSize ("HelveticaNeue-UltraLight", 30));
				Device.OnPlatform (Android: () => winPrizeLabel.Font = Font.FontForSize ("HelveticaNeue-Light", 30));
			} else {
				Device.OnPlatform (iOS: () => winPrizeLabel.Font = Font.FontForSize ("HelveticaNeue-UltraLight", 50));
				Device.OnPlatform (Android: () => winPrizeLabel.Font = Font.FontForSize ("Roboto-Light", 50));
			}

			StackLayout form = MakeForm ();
			form.VerticalOptions = LayoutOptions.FillAndExpand;

			var formView = new ContentView {
				Content = form,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};

			var spinButton = new Button {
				Text = "Spin",
				BackgroundColor = Color.Gray,
				TextColor = Color.White,
				WidthRequest = 100,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};

			spinButton.Activated += (s, e) => {
				var handler = SpinButtonPressed;
				if (handler != null) {
					string name = nameEntry.Text ?? "";
					string email = emailEntry.Text ?? "";
					string company = companyEntry.Text ?? "";
					bool completedChallenge = false;
					var args = new SpinButtonPressedArgs (name, email, company, completedChallenge);
					handler (this, args);
				}

			};

			var spinButtonView = new ContentView {
				Content = spinButton,
				WidthRequest = 250,
				HeightRequest = 150
			};

			var mainLayout = new StackLayout {
				Spacing = 20
			};

			mainLayout.Add (logo);
			mainLayout.Add (winPrizeLabel);
			mainLayout.Add (formView);
			mainLayout.Add(spinButtonView);

			var scollView = new ScrollView { 
				Content = mainLayout 
			};

			Content = new BackgroundImageContainer ("blurredbackground.png")
			{
				Content = scollView
			};

		}

		StackLayout MakeForm ()
		{
			nameEntry = new Entry {
				Placeholder = "Full Name",
				MinimumWidthRequest = 50,
			};

			emailEntry = new Entry {
				Placeholder = "Email",
				MinimumWidthRequest = 50,
			};

			companyEntry = new Entry {
				Placeholder = "Company",
				MinimumWidthRequest = 50,
			};

			var switchLabel = new Label {
				Text = "Completed Azure Mobile Services Challenge?",
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.Center,
				MinimumWidthRequest = 50,
			};


			Device.OnPlatform (iOS: () => switchLabel.Font = Font.FontForNamedSize ("HelveticaNeue-UltraLight", NamedSize.Small));
			Device.OnPlatform (Android: () => switchLabel.Font = Font.FontForNamedSize ("Sans-Serif-Light", NamedSize.Small));
			Device.OnPlatform (WinPhone: () => switchLabel.Font = Font.SystemFontOfSize (10));

			challengeSwitch = new Xamarin.QuickUI.Switch ();

			var switchContainer = new StackLayout {
				Orientation = StackLayout.StackOrientation.Horizontal,
			};

			switchContainer.Add (switchLabel);
			switchContainer.Add (challengeSwitch);

			var entryContainer = new StackLayout {
				Padding = new Thickness(0, 0, 10, 0),
				VerticalOptions = LayoutOptions.Center,
				Spacing = 15
			};

			entryContainer.Add (nameEntry);
			entryContainer.Add (emailEntry);
			entryContainer.Add (companyEntry);
			entryContainer.Add (switchContainer);

			var qrButton = new Image {
				Source = "qrcode.png",
				WidthRequest = 165,
				HeightRequest = 165,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
			};

			var result = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center,
			};

			if (isPhone) {
				result.Orientation = StackLayout.StackOrientation.Vertical;
			} else {
				result.Orientation = StackLayout.StackOrientation.Horizontal;
			}

			result.Add (entryContainer);
			result.Add (qrButton);

			result.SizeChanged += (sender, args) => System.Diagnostics.Debug.WriteLine (result.Bounds);

			return result;
		}
	}
}