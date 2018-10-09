using System;
using Xamarin.QuickUI;
using Xplat_Core;
using System.Windows.Input;
using System.Threading.Tasks;

namespace ImapClientAppShared
{
	/// <summary>
	/// View model for account exporting.
	/// </summary>
	public class ExportAccountViewModel : ViewModelBase
	{
		IQrService qrService;

		public ExportAccountViewModel() : base()
		{
			this.qrService = ServiceContainer.Resolve<IQrService> ();
		}

		/// <summary>
		/// Resets this model. The service container always holds one instance of a model.
		/// </summary>
		public void Reset ()
		{
			this.QrImageFilename = string.Empty;
		}

		/// <summary>
		/// Gets or sets the qr image filename.
		/// </summary>
		public string QrImageFilename
		{
			get
			{
				return base.GetProperty<string> ();
			}
			set
			{
				base.SetProperty (value);
				this.Validate ();
			}
		}

		/// <summary>
		/// Gets the export account command.
		/// </summary>
		/// <value>The export account command.</value>
		public ICommand ExportAccountCommand
		{
			get
			{
				if(this.exportAccountCommand == null)
				{
					this.exportAccountCommand = new DelegateCommand (obj => this.GenerateQrImage (), obj => this.IsValid);
				}
				return this.exportAccountCommand;
			}
		}
		ICommand exportAccountCommand;

		/// <summary>
		/// Generates the QR image.
		/// </summary>
		/// <returns>The qr image.</returns>
		async Task GenerateQrImage()
		{
			this.IsBusy = true;
			this.QrImageFilename = await this.qrService.GenerateQrImageFileAsync ("import@example.com|secret");
			this.IsBusy = false;
		}

		protected override void Validate ()
		{
			((DelegateCommand)this.ExportAccountCommand).RaiseCanExecuteChanged ();

			base.Validate ();
		}
	}
}

