using System;
using Xplat_Core;
using Xamarin.QuickUI;

namespace ImapClientAppShared
{
	/// <summary>
	/// The QuickUI App.
	/// </summary>
	public class ImapClientApp
	{
		/// <summary>
		/// Returns the main app. Singleton.
		/// </summary>
		/// <value>The main app.</value>
		public static ImapClientApp MainApp
		{
			get
			{
				if(mainApp == null)
				{
					mainApp = new ImapClientApp ();
				}
				return mainApp;
			}
		}
		static ImapClientApp mainApp;

		private ImapClientApp ()
		{
			// Register a fake service or the real Googlemail IMAP service.
			//ServiceContainer.Register<IImapService> (() => new GmailImapService());
			ServiceContainer.Register<IImapService> (() => new MockupImapService());

			// Register a fake QR service. The platform specific projects can inject their own service which uses for example ZXing Scanner.
			ServiceContainer.Register<IQrService> (() => new MockupQrService());

			// We need a view model for the login.
			ServiceContainer.Register<LoginViewModel> (() => new LoginViewModel {
				ImageFile = "drawable/placeholder.jpg",
				AfterLoginCallback = this.ExecuteAfterLogin,
			});

			// View model for the details page.
			ServiceContainer.Register<MailDetailsViewModel>(() => new MailDetailsViewModel());

			// View model for the inbox contents.
			ServiceContainer.Register<InboxContentViewModel> (() => new InboxContentViewModel ());

			// View model for exporting the account data.
			ServiceContainer.Register<ExportAccountViewModel> (() => new ExportAccountViewModel ());

			this.IsUserAuthenticated = false;
		}

		/// <summary>
		/// Gets or sets a value indicating whether the user has already logged in or not.
		/// </summary>
		public bool IsUserAuthenticated
		{
			get;
			set;
		}

		/// <summary>
		/// Executes the after login.
		/// </summary>
		/// <param name="loginSucceeded">If set to <c>true</c> login succeeded.</param>
		public void ExecuteAfterLogin(bool loginSucceeded)
		{
			if(loginSucceeded)
			{
				this.IsUserAuthenticated = true;
				//if(Device.Idiom == TargetIdiom.Phone)
				{
					this.MainPage.Navigation.PopModal ();
				}
//				else
//				{
//					var splitPage = (MasterDetailPage)this.MainPage;
//					splitPage.Detail.Navigation.PopModal ();
//				}

			}
			else
			{
				this.MainPage.DisplayAlert("Login", "Login failed. Please check username and password and retry.", "OK", null);
			}
		}

		/// <summary>
		/// Gets the main page.
		/// </summary>
		public Page MainPage
		{
			get
			{
				if(this.mainPage == null)
				{
					// TODO: Add support for tables by using a master-detail-view. Currently still buggy in QuickUI.
					//if(Device.Idiom == TargetIdiom.Phone)
					{
						var navPage = new NavigationPage (new InboxContentsPage());
						this.mainPage = navPage;
					}
//					else
//					{
//						var splitPage = new MasterDetailPage ();
//						splitPage.Master = new NavigationPage(new InboxContentsPage());
//						splitPage.Detail = new NavigationPage(new MailDetailsPage (null));
//						this.mainPage = splitPage;
//					}
				}
				return this.mainPage;
			}

		}
		Page mainPage;
	}
}

