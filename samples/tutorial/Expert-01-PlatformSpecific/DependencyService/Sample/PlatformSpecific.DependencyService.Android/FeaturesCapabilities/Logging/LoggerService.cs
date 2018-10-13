using System;

using HolisticWare.Mobile.Logging.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency(typeof(LoggerService))]

namespace HolisticWare.Mobile.Logging.XamarinAndroid
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

