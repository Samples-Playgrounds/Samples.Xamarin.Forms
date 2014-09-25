using System;


using PlatformSpecific.DependencyService.XamarinAndroid;


[assembly: Xamarin.Forms.Dependency(typeof(LoggerService))]

namespace PlatformSpecific.DependencyService.XamarinAndroid
{
	public class LoggerService 
		// : ILoggerService 		// TODO: this was in original project. Will be added in the future
	{
		public LoggerService ()
		{
		}

		public static void WriteLine (string log)
		{
			System.Diagnostics.Trace.WriteLine(log);


			//XUbertestersSDK.XUbertesters.LogInfo(log);

			return;
		}
	}
}

