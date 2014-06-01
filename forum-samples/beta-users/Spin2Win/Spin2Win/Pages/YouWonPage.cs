using System;
using Xamarin.QuickUI;

namespace Spin2Win
{
	public class YouWonPage : ContentPage
	{
		public event EventHandler DoneButtonPressed;

		public YouWonPage (PrizeType prizeWon)
		{
			SetupPage (prizeWon);
		}

		void SetupPage (PrizeType prize)
		{
			BackgroundImage = "youwinbackground.png";

			var youWonLabel = new Label {
				Text = "You Won!",
				TextColor = Color.White,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			Device.OnPlatform (iOS: () => youWonLabel.Font = Font.FontForSize ("HelveticaNeue-UltraLight", 50));

			var prizeImage = new Image {
				VerticalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 200
			};

			if (prize == PrizeType.Monkey)
				prizeImage.Source = "monkeystuff.png";
			else 
				prizeImage.Source = "tshirt.png";

			var enjoyPrizeLabel = new Label {
				TextColor = Color.White,
				XAlign = TextAlignment.Center,
				YAlign = TextAlignment.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			if (prize == PrizeType.Monkey)
				enjoyPrizeLabel.Text = "Enjoy your new Xamarin Monkey!";
			else
				enjoyPrizeLabel.Text = "Enjoy your new Xamarin t-shirt!";

			Device.OnPlatform (iOS: () => enjoyPrizeLabel.Font = Font.FontForSize ("HelveticaNeue-UltraLight", 35));

			var doneButton = new Button {
				Text = "Done",
				BackgroundColor = Color.Gray,
				TextColor = Color.White,
				WidthRequest = 100,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};

			var doneButtonContainer = new ContentView {
				HeightRequest = 125,
				Content = doneButton
			};

			doneButton.Activated += (s, e) => {
				Console.WriteLine ("Tapped!!");
				var handler = DoneButtonPressed;
				if (handler != null)
					handler (this, EventArgs.Empty);
			};

			var layout = new StackLayout {
				youWonLabel,
				prizeImage,
				enjoyPrizeLabel,
				doneButtonContainer
			};

			Content = new BackgroundImageContainer ("youwinbackground.png") {
				Content = layout
			};
		}
	}
}