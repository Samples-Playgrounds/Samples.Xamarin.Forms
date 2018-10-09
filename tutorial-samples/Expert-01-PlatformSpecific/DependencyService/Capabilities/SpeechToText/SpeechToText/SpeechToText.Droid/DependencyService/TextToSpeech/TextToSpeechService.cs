using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Android.Content;
using Android.Speech;

namespace SpeechToText.DependencyService.TextToSpeech.XamarinAndroid
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="https://forums.xamarin.com/discussion/22305/question-about-speech-recognizer-app"/>
	/// <see cref="http://forums.xamarin.com/discussion/12049/voice-recognition-without-the-popup"/>
	/// <see cref="https://github.com/oganix/MonoTouch-OpenEars"/>
	/// <see cref="http://viralpatel.net/blogs/android-speech-to-text-api/"/>
	/// <see cref="http://mobile.antonio081014.com/2012/09/speech-recognition-on-ios-with-openear.html"/>
	public partial class TextToSpeechService : ITextToSpeechService
	{

		public string RecordVoice()
		{
			Intent voiceIntent = new Intent(RecognizerIntent.ActionRecognizeSpeech);
			voiceIntent.PutExtra
							(
							RecognizerIntent.ExtraLanguageModel, 
							RecognizerIntent.LanguageModelFreeForm
							);
			voiceIntent.PutExtra
							(
							RecognizerIntent.ExtraPrompt, 
							Android.App.Application
								.Context.GetString
										(
										Android.Resource.String.messageSpeakNow
										)
										);
			voiceIntent.PutExtra
							(
							RecognizerIntent.ExtraSpeechInputCompleteSilenceLengthMillis, 
							1500
							);
			voiceIntent.PutExtra
							(
							RecognizerIntent.ExtraSpeechInputPossiblyCompleteSilenceLengthMillis, 
							1500
							);
			voiceIntent.PutExtra
							(
							RecognizerIntent.ExtraSpeechInputMinimumLengthMillis, 
							15000
							);
			voiceIntent.PutExtra
							(
							RecognizerIntent.ExtraMaxResults, 
							1
							);
			voiceIntent.PutExtra
							(
							RecognizerIntent.ExtraLanguage, 
							Java.Util.Locale.Default
							);
			StartActivityForResult
							(
							voiceIntent, 
							VOICE
							);

			return;
		}
	}
}
