using System;
using System.Linq;
using System.Collections.Generic;


using HolisticWare.Mobile.TextToSpeech;
using HolisticWare.Mobile.TextToSpeech.TextToSpeech.XamarinIOS;
using MonoTouch.AVFoundation;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechService))]

namespace HolisticWare.Mobile.TextToSpeech.TextToSpeech.XamarinIOS
{
	/// <summary>
	/// Text to speech service.
	/// </summary>
	/// <see cref="http://code.tutsplus.com/tutorials/android-sdk-using-the-text-to-speech-engine--mobile-8540"/>
	public partial class TextToSpeechService 
		: 
		ITextToSpeechService
	{
        string toSpeak;

		public TextToSpeechService ()
		{
		}

		public void Start ()
		{
			return;
		}


		public void Stop ()
		{
			return;
		}

		public void Speak (string text_to_speak)
		{
			AVSpeechSynthesizer speechSynthesizer = new AVSpeechSynthesizer ();

			AVSpeechUtterance speechUtterance = new AVSpeechUtterance (text_to_speak) 
			{
            	Rate = AVSpeechUtterance.MaximumSpeechRate/4,
            	Voice = AVSpeechSynthesisVoice.FromLanguage ("en-US"),
            	Volume = 0.5f,
            	PitchMultiplier = 1.0f
        };

        speechSynthesizer.SpeakUtterance (speechUtterance);

            return;
		}
            
		public List<string> LanguagesAvailable ()
		{
			List<string> languages_available = new List<string>{ "Default" };

			return languages_available;
		}

	}
}

