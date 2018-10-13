using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SpeechToText.Droid.DependencyService.TextToSpeech
{
	public partial class SpeechToTextActivity : Activity, IRecognitionListener
	{
		private SpeechRecognizer mSpeechRecognizer;
		private Intent mSpeechRecognizerIntent;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Create your application here

			mSpeechRecognizer = SpeechRecognizer.CreateSpeechRecognizer(this);
			mSpeechRecognizerIntent = new Intent(RecognizerIntent.ActionRecognizeSpeech);
			mSpeechRecognizerIntent.PutExtra(RecognizerIntent.ExtraCallingPackage, PackageName);
			mSpeechRecognizerIntent.PutExtra(RecognizerIntent.ExtraPrompt, GetString(Resource.String.VoiceCommandsDesc));
			mSpeechRecognizerIntent.PutExtra(RecognizerIntent.ExtraLanguageModel, this.Resources.Configuration.Locale.Language);
			mSpeechRecognizerIntent.PutExtra(RecognizerIntent.ExtraMaxResults, 5);
			Button StartListening = FindViewById<Button>(Resource.Id.Startlisning);
			StartListening.Click += StartListening_Click;
		}

		void StartListening_Click(object sender, EventArgs e)
		{
			mSpeechRecognizer.StartListening(mSpeechRecognizerIntent);
		}

		public void OnBeginningOfSpeech()
		{
			throw new NotImplementedException();
		}

		public void OnBufferReceived(byte[] buffer)
		{
			throw new NotImplementedException();
		}

		public void OnEndOfSpeech()
		{
			throw new NotImplementedException();
		}

		public void OnError(SpeechRecognizerError error)
		{
			throw new NotImplementedException();
		}

		public void OnEvent(int eventType, Bundle @params)
		{
			throw new NotImplementedException();
		}

		public void OnPartialResults(Bundle partialResults)
		{
			throw new NotImplementedException();
		}

		public void OnReadyForSpeech(Bundle @params)
		{
			throw new NotImplementedException();
		}

		public void OnResults(Bundle results)
		{
			IList<string> matches = results.GetStringArrayList(SpeechRecognizer.ResultsRecognition);
		}

		public void OnRmsChanged(float rmsdB)
		{
			throw new NotImplementedException();
		}
	}
}