using System;
using System.Collections.Generic;

namespace HolisticWare.Mobile.TextToSpeech.TextToSpeech
{
	public interface ITextToSpeechService
	{
		void Start();

		void Stop();

		void Speak(string text);

		List<string> LanguagesAvailable();


	}
}
