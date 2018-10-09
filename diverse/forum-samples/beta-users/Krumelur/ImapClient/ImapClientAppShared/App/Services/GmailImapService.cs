using System;
using System.Threading.Tasks;
using System.Threading;
using S22.Imap;
using System.Net.Mail;
using System.Linq;
using System.Net;

namespace ImapClientAppShared
{
	/// <summary>
	/// Logs a user into his Gmail Account and allows retrieving mails.
	/// </summary>
	public sealed class GmailImapService : IImapService, IDisposable
	{
		public GmailImapService()
		{
		}

		private ImapClient client;
		private string senderAddress;
		private string senderPassword;

		public void Dispose()
		{
			this.senderAddress = null;
			this.senderPassword = null;

			if(this.client != null)
			{
				this.client.Dispose ();
				this.client = null;
			}
		}

		private async Task<bool> LoginIfPossibleAndRequired()
		{
			if(this.IsAuthenticated)
			{
				// Already authenticated.
				return true;
			}

			if(this.senderAddress != null && this.senderPassword != null)
			{
				await this.LoginAsync (this.senderAddress, this.senderPassword);

				// Still not authenticated? 
				return false;
			}
			else
			{
				// No credentials.
				return false;
			}
		}

		#region ILoginService implementation

		public bool IsAuthenticated
		{
			get
			{
				return this.client != null && this.client.Authed;
			}
		}

		public async Task<bool> LoginAsync (string username, string password, CancellationToken ct = default(CancellationToken))
		{
			this.senderAddress = null;
			this.senderPassword = null;

			// Logs a user in to his google account.
			bool loginResult = await Task<bool>.Run (() => {
				this.client = new ImapClient("imap.gmail.com", 993, username, password, AuthMethod.Login, true);
				return this.client.Authed;
			});

			if(loginResult)
			{
				this.senderAddress = username;
				this.senderPassword = password;
			}

			return loginResult;
		}

		public async Task<MailMessage[]> GetInboxMessagesAsync (CancellationToken ct = default(CancellationToken))
		{
			bool loggedIn = await this.LoginIfPossibleAndRequired ();
			if(!loggedIn)
			{
				return new MailMessage[0];
			}

			MailMessage[] messages = await Task<MailMessage[]>.Run (() => {
				uint[] inboxMsgIds = this.client.Search (SearchCondition.All ());
				return this.client.GetMessages (inboxMsgIds);
			});

			if(messages == null)
			{
				messages = new MailMessage[0];
			}

			return messages;
		}

		public async Task SendMessageAsync (string recipient, string subject, string body, CancellationToken ct = default(CancellationToken))
		{
			bool loggedIn = await this.LoginIfPossibleAndRequired ();
			if (!loggedIn)
			{
				return;
			}

			await Task.Run (() => {
				var credential = new NetworkCredential(this.senderAddress, this.senderPassword);
				var message = new MailMessage (this.senderAddress, recipient, subject, body);
				var smtp = new SmtpClient ("smtp.gmail.com", 587) {
					EnableSsl = true,
					Credentials = credential
				};
				smtp.SendAsync (message, null);
			});
		}

		#endregion
	}
}

