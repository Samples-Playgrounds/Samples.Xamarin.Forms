using System;


using PlatformSpecific.DependencyService.FeaturesCapabilities.Logging.WindowsPhone;


[assembly: Xamarin.Forms.Dependency(typeof(LoggerService))]

namespace PlatformSpecific.DependencyService.FeaturesCapabilities.Logging.WindowsPhone
{
	public class LoggerService : ILoggerService
	{
		public LoggerService ()
		{
		}

		public void WriteLine (string log)
		{
			// Windows Phone
			System.Diagnostics.Debug.WriteLine(log);

			// Windows Phone - no Trace
			//System.Diagnostics.Trace.WriteLine(log);
			// XPlat .net/mono
			System.Diagnostics.Debug.WriteLine(log);

			return;
		}
	}
}

