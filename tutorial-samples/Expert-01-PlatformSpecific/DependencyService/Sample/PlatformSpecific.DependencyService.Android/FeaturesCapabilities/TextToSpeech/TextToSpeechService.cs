using System;
using System.Linq;
using System.Collections.Generic;


using HolisticWare.Mobile.TextToSpeech;
using HolisticWare.Mobile.TextToSpeech.TextToSpeech.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechService))]

namespace HolisticWare.Mobile.TextToSpeech.TextToSpeech.XamarinAndroid
{
	/// <summary>
	/// Text to speech service.
	/// </summary>
	/// <see cref="http://code.tutsplus.com/tutorials/android-sdk-using-the-text-to-speech-engine--mobile-8540"/>
	public partial class TextToSpeechService 
		: 
		Java.Lang.Object,
		Android.Speech.Tts.TextToSpeech.IOnInitListener,
		ITextToSpeechService
	{
		Android.Speech.Tts.TextToSpeech speaker;
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
			var ctx = Xamarin.Forms.Forms.Context; 

            if (speaker == null)
            {
				speaker = new Android.Speech.Tts.TextToSpeech(ctx, this);
            }
            else
            {
				Dictionary<string, string> p = new Dictionary<string, string>();
				speaker.Speak(text_to_speak, Android.Speech.Tts.QueueMode.Flush, p);
            }

            return;
		}

		#region IOnInitListener implementation
        public void OnInit(Android.Speech.Tts.OperationResult status)
        {
            if (status.Equals(Android.Speech.Tts.OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, Android.Speech.Tts.QueueMode.Flush, p);
            }
        }
        #endregion

        Android.Speech.Tts.TextToSpeech textToSpeech;

		public List<string> LanguagesAvailable ()
		{
			List<string> languages_available = new List<string>{ "Default" };
			var localesAvailable = Java.Util.Locale.GetAvailableLocales().ToList();

			foreach (var locale in localesAvailable)
			{
			    Android.Speech.Tts.LanguageAvailableResult language_available = textToSpeech.IsLanguageAvailable(locale);
			    switch (language_available)
			    {
			        case Android.Speech.Tts.LanguageAvailableResult.Available:
			          languages_available.Add(locale.DisplayLanguage);
			          break;
			        case Android.Speech.Tts.LanguageAvailableResult.CountryAvailable:
			          languages_available.Add(locale.DisplayLanguage);
			          break;
			        case Android.Speech.Tts.LanguageAvailableResult.CountryVarAvailable:
			          languages_available.Add(locale.DisplayLanguage);
			          break;
			    }
			}

			languages_available = languages_available.OrderBy(t => t).Distinct().ToList();		

			return languages_available;
		}

		public void InstallLanguage ()
		{
			Android.Content.Intent checkTTSIntent = new Android.Content.Intent();
			checkTTSIntent.SetAction(Android.Speech.Tts.TextToSpeech.Engine.ActionCheckTtsData);
			//StartActivityForResult(checkTTSIntent, NeedLang);
			//
			//protected override void OnActivityResult(int req, Result res, Intent data)
			//{
			    //if (req == NeedLang)
			    //{
					Android.Content.Intent installTTS = new Android.Content.Intent();
					installTTS.SetAction(Android.Speech.Tts.TextToSpeech.Engine.ActionInstallTtsData);
			        //StartActivity(installTTS);
			    //}
			//}
   		}
	}
}

