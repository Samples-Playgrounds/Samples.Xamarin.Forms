using System;

namespace HolisticWare.Mobile.MultiMedia.Audio
{
	public interface IAudioPlayerService
	{
		void Play();

		void Play(string file);

		void Stop();

		void Pause();
	}
}

