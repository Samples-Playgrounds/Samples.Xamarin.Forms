using System;
using System.Threading.Tasks;
using System.Threading;
using ZXing.Mobile;
using MonoTouch.UIKit;
using ImapClientApp_iOS;
using Xamarin.QuickUI;
using ImapClientAppShared;

namespace ImapClientApp_iOS
{
	public class ZXingQrService : IQrService
	{
		public ZXingQrService ()
		{
		}

		public Page Page
		{
			get;
			set;
		}

		#region IQrService implementation

		public Task<string> GenerateQrImageFileAsync (string content)
		{
			return Task.FromResult ("drawable/sampleqrcode.png");
		}

		public async Task<string> ScanQrImageAsync ()
		{
			var barcodeScanner = new MobileBarcodeScanner ();
			var result = await barcodeScanner.Scan ();
			return result != null ? result.Text : string.Empty;
		}

		#endregion
	}
}

