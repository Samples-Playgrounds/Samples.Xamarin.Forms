using System;
using System.Threading.Tasks;

namespace ImapClientAppShared
{
	/// <summary>
	/// Service to read and create QR codes.
	/// </summary>
	interface IQrService
	{
		/// <summary>
		/// Generates a QR code with given content and stores it on disk as a PNG image.
		/// </summary>
		/// <returns>Path to the image.</returns>
		/// <param name="content">Content to encode.</param>
		Task<string> GenerateQrImageFileAsync (string content);

		/// <summary>
		/// Reads a QR code.
		/// </summary>
		/// <returns>Content of the QR code.</returns>
		Task<string> ScanQrImageAsync ();
	}
}

