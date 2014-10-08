using System;


using PlatformSpecific.DependencyService.FeaturesCapabilities.Logging.XamarinAndroid;


[assembly: Xamarin.Forms.Dependency(typeof(LoggerService))]

namespace PlatformSpecific.DependencyService.FeaturesCapabilities.Logging.XamarinAndroid
{
	public class LoggerService : ILoggerService
	{
		public LoggerService ()
		{
		}

		public void WriteLine (string log)
		{
			// Android
			Android.Util.Log.Info("Xamarin.Forms Dependency Logging", log);

			// XPlat .net/mono
			System.Diagnostics.Trace.WriteLine(log);


			//XUbertestersSDK.XUbertesters.LogInfo(log);

			return;
		}
	}
}

