using System;
using Xplat_Core;
using System.Windows.Input;

namespace ImapClientAppShared
{
	/// <summary>
	/// View model for the login page.
	/// </summary>
	public class LoginViewModel : ViewModelBase
	{
		readonly IImapService imapService;

		public LoginViewModel () : base()
		{
			this.imapService = ServiceContainer.Resolve<IImapService> ();
		}

		public Action<bool> AfterLoginCallback;

		/// <summary>
		/// Gets or sets the image file.
		/// </summary>
		/// <value>The image file.</value>
		public string ImageFile
		{
			get
			{
				return this.GetProperty<string> ();
			}
			set{
				this.SetProperty<string> (value);
				this.Validate ();
			}
		}

		/// <summary>
		/// Gets or sets the username.
		/// </summary>
		/// <value>The username.</value>
		public string Username
		{
			get
			{
				return this.GetProperty<string> ();
			}
			set{
				this.SetProperty<string> (value);
				this.Validate ();
			}
		}

		/// <summary>
		/// Gets or sets the password.
		/// </summary>
		/// <value>The password.</value>
		public string Password
		{
			get
			{
				return this.GetProperty<string> ();
			}
			set{
				this.SetProperty<string> (value);
				this.Validate ();
			}
		}

		protected override void Validate ()
		{
			base.Validate ();
			((DelegateCommand)this.LoginCommand).RaiseCanExecuteChanged();
			((DelegateCommand)this.ImportCommand).RaiseCanExecuteChanged();
		}

		/// <summary>
		/// Gets a value indicating whether the login is valid.
		/// </summary>
		public bool IsLoginValid
		{
			get{
				return !string.IsNullOrWhiteSpace (this.Username) && !string.IsNullOrWhiteSpace (this.Password);
			}
		}

		/// <summary>
		/// Executes a callback in case the login succeeded. This can be used by the UI to navigate away from the page.
		/// </summary>
		public async void ExecuteAfterLoginCallback()
		{
			this.IsBusy = true;
			bool loginSuccess = await this.imapService.LoginAsync (this.Username, this.Password);

			var del = this.AfterLoginCallback;
			if (del != null)
			{
				del (loginSuccess);
			}

			this.IsBusy = false;
		}

		/// <summary>
		/// Gets the login command.
		/// </summary>
		/// <value>The login command.</value>
		public ICommand LoginCommand
		{
			get
			{
				if(this.loginCommand == null)
				{
					this.loginCommand = new DelegateCommand (obj => this.ExecuteAfterLoginCallback(), obj => this.IsLoginValid && !this.IsBusy);
				}
				return this.loginCommand;
			}
		}
		ICommand loginCommand;

		/// <summary>
		/// Imports account via QR code scanning.
		/// </summary>
		async void ImportAccount()
		{
			var qrService = ServiceContainer.Resolve<IQrService> ();
			string accountInfo = await qrService.ScanQrImageAsync ();
			if (!string.IsNullOrWhiteSpace(accountInfo) && accountInfo.Contains("|"))
			{
				int splitIndex = accountInfo.LastIndexOf ("|");
				string importLogin = accountInfo.Substring (0, splitIndex);
				string importPassword = accountInfo.Substring (splitIndex + 1);

				this.Username = importLogin;
				this.Password = importPassword;
			}
			else
			{
				// TODO: ViewModel needs to display an error. We need to inject some service which handles this as I don't want to have UI code here!
			}
		}

		/// <summary>
		/// Gets the import command.
		/// </summary>
		/// <value>The import command.</value>
		public ICommand ImportCommand
		{
			get
			{
				if(this.importCommand == null)
				{
					this.importCommand = new DelegateCommand (obj => this.ImportAccount(), obj => !this.IsBusy);
				}
				return this.importCommand;
			}
		}
		ICommand importCommand;
	}
}

