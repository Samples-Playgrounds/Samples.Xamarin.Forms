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
	/// Mocked IMAP service. Returns hardcoded test data.
	/// </summary>
	public sealed class MockupImapService : IImapService, IDisposable
	{
		public class DummyClient
		{
			public bool Authed;
		}

		public MockupImapService()
		{
		}

		private DummyClient client;
		private string senderAddress;
		private string senderPassword;

		public void Dispose()
		{
			this.senderAddress = null;
			this.senderPassword = null;
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
				Console.WriteLine("Sleeping to simulate login...");
				this.client = new DummyClient();
				this.client.Authed = true;
				Thread.Sleep(500);
				Console.WriteLine("Sleeping done.");
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
				var fakeMessages = new MailMessage[] {
					new MailMessage("sender1@domain.com", "rene.ruppert.test@gmail.com", "Subbject 1", "Body 1"),
					new MailMessage("sender2@domain.com", "rene.ruppert.test@gmail.com", "Subbject 2", "Body 2"),
					new MailMessage("sender3@domain.com", "rene.ruppert.test@gmail.com", "Subbject 3", "Body 3"),
					new MailMessage("sender4@domain.com", "rene.ruppert.test@gmail.com", "Subbject 4", "Body 4")
				};
				Console.WriteLine("Sleeping to simulate message retrieval...");
				Thread.Sleep(1000);
				Console.WriteLine("Sleeping done.");
				return fakeMessages;
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
				Console.WriteLine("Simulating mail send async.");
			});
		}

		#endregion
	}
}

