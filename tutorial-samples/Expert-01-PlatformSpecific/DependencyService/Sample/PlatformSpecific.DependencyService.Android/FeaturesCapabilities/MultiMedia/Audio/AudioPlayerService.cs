using System;
using System.Linq;

using Android.Content;


using HolisticWare.Mobile.MultiMedia.Audio;
using HolisticWare.Mobile.MultiMedia.Audio.XamarinAndroid;

[assembly:Xamarin.Forms.Dependency(typeof(AudioPlayerService))]

namespace HolisticWare.Mobile.MultiMedia.Audio.XamarinAndroid
{
	public partial class AudioPlayerService : IAudioPlayerService
	{ 
		public AudioPlayerService ()
		{
			return;	
		}
			
		public void Play ()
		{
		}

		public void Play (string file)
		{
		}

		public void Stop ()
		{
		}

		public void Pause ()
		{
		}
	}
}

