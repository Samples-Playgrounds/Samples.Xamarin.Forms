using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Mail;

namespace ImapClientAppShared
{
	/// <summary>
	/// IMAP service. This is used to access an IMAP server.
	/// </summary>
	public interface IImapService
	{
		/// <summary>
		/// Returns if the user is already authenticated.
		/// </summary>
		/// <value><c>true</c> if this instance is authenticated; otherwise, <c>false</c>.</value>
		bool IsAuthenticated { get; }

		/// <summary>
		/// Logs the user in.
		/// </summary>
		/// <returns>TRUE if login succeeded, otherwise FALSE</returns>
		/// <param name="username">Username.</param>
		/// <param name="password">Password.</param>
		/// <param name="ct">Token to cancel</param>
		Task<bool> LoginAsync(string username, string password, CancellationToken ct = default(CancellationToken));

		/// <summary>
		/// Gets the inbox messages.
		/// </summary>
		/// <returns>The inbox messages.</returns>
		/// <param name="ct">Token to cancel</param>
		Task<MailMessage[]> GetInboxMessagesAsync (CancellationToken ct = default(CancellationToken));

		/// <summary>
		/// Sends a message to a recipient.
		/// </summary>
		/// <returns>A task</returns>
		/// <param name="recipient">Recipient.</param>
		/// <param name="subject">Subject.</param>
		/// <param name="message">Message.</param>
		/// <param name="ct">Token to cancel</param>
		Task SendMessageAsync (string recipient, string subject, string message, CancellationToken ct = default(CancellationToken));
	}
}

