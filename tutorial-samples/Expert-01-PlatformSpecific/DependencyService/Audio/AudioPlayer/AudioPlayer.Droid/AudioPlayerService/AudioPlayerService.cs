using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly:Dependency(typeof(AudioPlayerService))]

namespace HolisticWare.Mobile.Audio.AudioPlayer.XamarinAndroid
{
	public partial class AudioPlayerService : IAudioPlayerService
	{
	}
}