using System;
using Xplat_Core;
using System.Windows.Input;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ImapClientAppShared
{
	/// <summary>
	/// View model for the inbox list.
	/// </summary>
	public class InboxContentViewModel : ViewModelBase
	{
		readonly IImapService imapService;

		public InboxContentViewModel () : base()
		{
			this.imapService = ServiceContainer.Resolve<IImapService> ();
		}

		/// <summary>
		/// Gets or sets the messages.
		/// </summary>
		/// <value>The messages.</value>
		public IList<MailMessage> Messages
		{
			get
			{
				return this.GetProperty<IList<MailMessage>> ();
			}
			set
			{
				this.SetProperty (value);
			}
		}

		protected override void Validate ()
		{
			base.Validate ();
			((DelegateCommand)this.RefreshMessagesCommand).RaiseCanExecuteChanged();
		}

		/// <summary>
		/// Returns if the message list has been synced once. Syncing is done once if the view appears.
		/// </summary>
		public bool HasSyncedMessagesOnce
		{
			get
			{
				return this.imapService.IsAuthenticated && this.messagedRetrieved;
			}
		}

		bool messagedRetrieved;

		/// <summary>
		/// Updates the messages from server.
		/// </summary>
		public async Task UpdateMessagesFromServerAsync()
		{
			this.IsBusy = true;

			this.Messages = new List<MailMessage> ();
			this.Messages = await this.imapService.GetInboxMessagesAsync ();
			this.IsBusy = false;
			this.messagedRetrieved = true;
		}

		/// <summary>
		/// Gets the refresh messages command.
		/// </summary>
		/// <value>The refresh messages command.</value>
		public  ICommand RefreshMessagesCommand
		{
			get
			{
				if(this.refreshMessagesCommand == null)
				{
					this.refreshMessagesCommand = new DelegateCommand (obj => this.UpdateMessagesFromServerAsync (), obj => !this.IsBusy);
				}
				return this.refreshMessagesCommand;
			}
		}
		private ICommand refreshMessagesCommand;

		/// <summary>
		/// Gets triggered if a message was selected. The UI can then navigate to a detail view.
		/// Navigation is not done in the view models because it is something that is specific to QuickUI. 
		/// View models are supposed to be free from any UI references.
		/// </summary>
		public Action<MailDetailsViewModel> MessageSelected;

		void OnMessageSelected(MailDetailsViewModel mailDetailViewModel)
		{
			var del = this.MessageSelected;
			if(del != null)
			{
				del (mailDetailViewModel);
			}
		}

		/// <summary>
		/// Gets the message selected command.
		/// </summary>
		/// <value>The message selected command.</value>
		public ICommand MessageSelectedCommand
		{
			get
			{
				if(this.messageSelectedCommand == null)
				{
					this.messageSelectedCommand = new DelegateCommand (obj => {
						var mailDetailViewModel = ServiceContainer.Resolve<MailDetailsViewModel> ();
						mailDetailViewModel.Message = (MailMessage)obj;

						this.OnMessageSelected(mailDetailViewModel);
					}, obj => !this.IsBusy);
				}
				return this.messageSelectedCommand;
			}
		}
		ICommand messageSelectedCommand;
	}
}

