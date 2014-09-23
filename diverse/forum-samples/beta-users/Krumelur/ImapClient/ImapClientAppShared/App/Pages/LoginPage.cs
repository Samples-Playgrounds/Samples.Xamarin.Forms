using System;
using Xamarin.QuickUI;
using Xplat_Core;

namespace ImapClientAppShared
{
	/// <summary>
	/// The login page.
	/// </summary>
	public class LoginPage : ContentPage
	{
		readonly LoginViewModel model;

		public LoginPage () : base()
		{
			this.model = ServiceContainer.Resolve<LoginViewModel> ();

			// Setting the binding context to the model allows binding the Entry elements!
			this.BindingContext = this.model;

			this.userImg = new Image {
				Shadow = true
			};

			// Bind image file path.
			this.userImg.SetBinding (Image.SourceProperty, new Binding ("ImageFile", BindingMode.OneWay, new FilePathToImageSourceConverter ()));

			this.usernameTxt = new Entry {
				Password = false,
				Placeholder = "Username",
			};
			// Bind username to the model.
			this.usernameTxt.SetBinding (Entry.TextProperty, new Binding ("Username"));
			this.passwordTxt = new Entry {

				Password = true,
				Placeholder = "Password"
			};
			// Bind password to the model.
			this.passwordTxt.SetBinding (Entry.TextProperty, new Binding ("Password", BindingMode.TwoWay));

			this.loginBtn = new Button
 			{
				ClassId = "loginButton",
				Text = "Login!",
			};
			loginBtn.SetBinding (Button.CommandProperty, new Binding ("LoginCommand"));

			var importBtn = new Button
			{
				Text = "Import account via QR code",
			};
			importBtn.SetBinding (Button.CommandProperty, new Binding ("ImportCommand"));

			var layout = new StackLayout {
				Orientation = StackLayout.StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.Start,
				Spacing = 15
			}.WithChildren (
				this.userImg,
				this.usernameTxt,
				this.passwordTxt,
				this.loginBtn,
				importBtn
			);

			this.Content = layout;
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
			this.model.IsBusyChanged += this.HandleBusyChanged;
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
			this.model.IsBusyChanged -= this.HandleBusyChanged;
		}

		void HandleBusyChanged(object sender, EventArgs args)
		{
			this.IsBusy = this.model.IsBusy;
		}

		Image userImg;
		Entry usernameTxt;
		Entry passwordTxt;
		Button loginBtn;
	}
}

