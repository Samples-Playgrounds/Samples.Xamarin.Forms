using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolisticWare.Mobile.Audio.AudioPlayer
{
	public partial interface IAudioPlayerService
	{
		void Play(string folder, string file);

	}
}
