using System;
using System.Threading.Tasks;
using System.Threading;

namespace ImapClientAppShared
{
	/// <summary>
	/// Fake QR code service. Encodes and decodes hardcoded data.
	/// </summary>
	public class MockupQrService : IQrService
	{
		public MockupQrService ()
		{
			this.content = "uninitialized@qrcode.com|password";
		}

		#region IQrService implementation

		public Task<string> GenerateQrImageFileAsync (string content)
		{
			return Task.Run (() => {
				Console.WriteLine("Sleeping to simulate QR code generation...");
				Thread.Sleep(500);
				this.content = content;
				return "drawable/sampleqrcode.png";
			});
		}

		string content;

		public Task<string> ScanQrImageAsync ()
		{
			return Task.Run (() => {
				Console.WriteLine("Sleeping to simulate QR code scanning...");
				Thread.Sleep(500);
				return this.content;
			});
		}

		#endregion
	}
}

