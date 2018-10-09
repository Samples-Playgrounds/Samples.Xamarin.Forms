using System;
using System.Collections.Generic;
using Xamarin.Forms;

using HolisticWare.Mobile.Logging;
using HolisticWare.Mobile.Bluetooth;
using HolisticWare.Mobile.TextToSpeech;

namespace PlatformSpecific.DependencyService
{	
	public partial class PageMain : ContentPage
	{	
		public PageMain ()
		{
			InitializeComponent ();
		}

		private void buttonTextToSpeech_Clicked (object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageTextToSpeech());

			return;
		}

		private void buttonAudioRecorder_Clicked (object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageTextToSpeech());

			return;
		}

		private void buttonAudioPlayer_Clicked (object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageAudioRecorder());

			return;
		}

		private void buttonBluetooth_Clicked (object sender, EventArgs ea)
		{
			this.Navigation.PushModalAsync(new PageBluetoothPrinter());

			return;
		}


	}
}

