using System;
using System.Collections.Generic;
using Xamarin.Forms;

using PlatformSpecific.DependencyService.FeaturesCapabilities.Logging;
using PlatformSpecific.DependencyService.FeaturesCapabilities.Bluetooth;
using PlatformSpecific.DependencyService.FeaturesCapabilities.TextToSpeech;

namespace PlatformSpecific.DependencyService
{	
	public partial class PageMain : ContentPage
	{	
		public PageMain ()
		{
			InitializeComponent ();
		}

		private void buttonBluetooth_Clicked (object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageBluetoothPrinter());

			return;
		}

		private void buttonTextToSpeech_Clicked (object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageTextToSpeech());

			return;
		}
	}
}

