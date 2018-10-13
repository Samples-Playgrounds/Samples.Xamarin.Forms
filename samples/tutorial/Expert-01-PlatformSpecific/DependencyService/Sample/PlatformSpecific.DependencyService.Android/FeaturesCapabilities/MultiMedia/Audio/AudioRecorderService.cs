using System;
using System.Linq;

using Android.Content;


using Android.Media;
using HolisticWare.Mobile.MultiMedia.Audio;


using PlatformSpecific.DependencyService.FeaturesCapabilities.MultiMedia.Audio.XamarinAndroid;
using System.IO;

[assembly:Xamarin.Forms.Dependency(typeof(AudioRecorderService))]

namespace PlatformSpecific.DependencyService.FeaturesCapabilities.MultiMedia.Audio.XamarinAndroid
{
	public partial class AudioRecorderService : IAudioRecorderService
	{ 
		public AudioRecorderService ()
		{
			return;	
		}

		public void Start ()
		{
			/// http://miguel.zakharia.me/post/38488118927/how-to-create-an-sdcard-file-for-the-android

			string folder_external = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;

			folder_external = Path.Combine(folder_external, "testaudio.mp3");

			string folder_music = Android.OS.Environment.DirectoryMusic;
			Java.IO.File folder_external_music = Android.OS.Environment.GetExternalStoragePublicDirectory(folder_music);

			string filePath = folder_external_music + "/Xamarin.Forms/test.mp3";

			MediaPlayer mediaPlayer = new  MediaPlayer();
			mediaPlayer.SetDataSource(filePath);
			mediaPlayer.Prepare();   
			mediaPlayer.Start();

		}			

		public void Record ()
		{
			Java.IO.File sdDir = null;
			string filePath = sdDir + "/" + "testAudio.mp3";

		}
	}
}

