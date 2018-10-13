using System;
using System.Collections.Generic;
using Xamarin.Forms;


using HolisticWare.Mobile.TextToSpeech.TextToSpeech;

namespace HolisticWare.Mobile.TextToSpeech
{
	public partial class ContentViewTextToSpeechService : ContentView, IDisposable

	{
		ITextToSpeechService text_to_speech_service = null;

		public ContentViewTextToSpeechService ()
		{
			InitializeComponent ();

			text_to_speech_service = DependencyService.Get<ITextToSpeechService>();

		}

		private void buttonSpeak_Clicked (object sender, EventArgs ea)
		{
			string text_to_speak = editorTextToSpeak.Text;
			text_to_speech_service.Speak(text_to_speak);

			return;
		}

		#region IDisposable implementation
		public void Dispose ()
		{
			text_to_speech_service.Stop();
			text_to_speech_service = null;

			return;
		}
		#endregion
	}
}

