using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HolisticWare.XamarinForms.Mobile.Audio.AudioPlayer
{
	public partial class ContentViewAudioPlayer : ContentView
	{
		List<string> Songs = null;

		public ContentViewAudioPlayer ()
		{
			InitializeComponent ();

			Songs =  new List<string>()
			{
				"DASD",
				"sdada"
			};

			this.pickerSongs.Items.Clear();
            foreach (var color in Songs)
            {
                pickerSongs.Items.Add(color);
            }
			return;
		}
	}
}

