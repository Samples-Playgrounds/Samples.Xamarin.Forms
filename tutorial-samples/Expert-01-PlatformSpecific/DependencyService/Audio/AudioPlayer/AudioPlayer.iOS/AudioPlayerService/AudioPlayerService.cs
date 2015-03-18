using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[
	assembly:
	Xamarin.Forms.Dependency(typeof(HolisticWare.Mobile.Audio.AudioPlayer.XamarinIOS.AudioPlayerService))
]

namespace HolisticWare.Mobile.Audio.AudioPlayer.XamarinIOS
{
	public partial class AudioPlayerService : IAudioPlayerService
	{

		AVFoundation.AVAudioPlayer player = null;

		public void Play(string folder, string filename)
		{

		    try
		    {
		        string file = System.IO.Path.Combine("Music", filename);
				Foundation.NSUrl Soundurl = Foundation.NSUrl.FromFilename(file);
		        player = AVFoundation.AVAudioPlayer.FromUrl(Soundurl);
		       
				player.CurrentTime = player.Duration*2;
				player.NumberOfLoops = 1;
				player.Volume = 1.0f;
				player.FinishedPlaying += DidFinishPlaying;
				player.PrepareToPlay();
				player.Play();
		    }
		    catch (Exception e)
		    {
		        System.Diagnostics.Debug.WriteLine("PlaySound: Error: " + e.Message, true);
		    }
		}

		public static void DidFinishPlaying(object sender , AVFoundation.AVStatusEventArgs e)
		{
		    if (e.Status)
		    {
		    }

		    return;
		}

	}
}