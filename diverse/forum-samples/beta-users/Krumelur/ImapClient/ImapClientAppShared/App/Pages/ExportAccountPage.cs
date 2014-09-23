using System;
using Xamarin.QuickUI;
using Xplat_Core;

namespace ImapClientAppShared
{
	/// <summary>
	/// Used to demonstrate how platform specifc components from the Component Store can be integrated into a QuickUI app.
	/// This page encodes the currently logged in user's username and password into a QR code and displayes the code on the screen.
	/// If the app is started on another device, there is a button on the login screen that allows you to import account data via a QR
	/// code. Scan this code and your second device will use the same account information.
	/// </summary>
	public class ExportAccountPage : ContentPage
	{
		readonly ExportAccountViewModel model;

		public ExportAccountPage () : base()
		{
			this.model = ServiceContainer.Resolve<ExportAccountViewModel> ();
			this.model.Reset ();
			this.BindingContext = this.model;

			var exportBtn = new Button {
				Text = "Export account"
			};
			exportBtn.SetBinding (Button.CommandProperty, new Binding ("ExportAccountCommand"));


			var qrImg = new Image {
				WidthRequest = 150,
				HeightRequest = 150
			};
			qrImg.SetBinding (Image.SourceProperty, new Binding ("QrImageFilename", BindingMode.OneWay, new FilePathToImageSourceConverter()));
		
			var layout = new StackLayout {
				Orientation = StackLayout.StackOrientation.Vertical
			}.WithChildren (
				exportBtn,
				qrImg
			);

			this.BackgroundColor = Color.White;
			this.Content = layout;
		}
	}
}

