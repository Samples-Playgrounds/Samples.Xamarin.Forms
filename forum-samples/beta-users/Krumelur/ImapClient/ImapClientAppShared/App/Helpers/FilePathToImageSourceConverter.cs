using System;
using Xamarin.QuickUI;

namespace ImapClientAppShared
{
	/// <summary>
	/// The view models are supposed to work in any environment and not only with QuickUI. As QuickUI's Image requires an ImageSource
	/// as binding, this value converter is used to convert a string (file path) into a FileImageSource and back.
	/// </summary>
	public class FilePathToImageSourceConverter : IValueConverter
	{
		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			var imgSource = new FileImageSource {
				File = (string)value
			};
			return imgSource;
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			string retValue = string.Empty;
			var imgSource = value as FileImageSource;
			if(imgSource != null)
			{
				retValue = imgSource.File;
			}
			return retValue;
		}

		#endregion


	}
}

