using System;
using Xplat_Core;
using System.Net.Mail;

namespace ImapClientAppShared
{
	/// <summary>
	/// View model for the mail details page.
	/// </summary>
	public class MailDetailsViewModel : ViewModelBase
	{
		public MailDetailsViewModel () : base()
		{
		}

		/// <summary>
		/// Gets or sets the message.
		/// </summary>
		public MailMessage Message
		{
			get
			{
				return base.GetProperty<MailMessage> ();
			}
			set
			{
				base.SetProperty (value);
			}
		}

		/// <summary>
		/// Gets the subject.
		/// </summary>
		public string Subject
		{
			get
			{
				return this.Message != null ? this.Message.Subject : string.Empty;
			}
		}

		/// <summary>
		/// Gets the body.
		/// </summary>
		public string Body
		{
			get
			{
				return this.Message != null ? this.Message.Body : string.Empty;
			}
		}

		/// <summary>
		/// Gets the sender address.
		/// </summary>
		public string From
		{
			get
			{
				return this.Message != null ? this.Message.From.Address : string.Empty;
			}
		}
	}
}

