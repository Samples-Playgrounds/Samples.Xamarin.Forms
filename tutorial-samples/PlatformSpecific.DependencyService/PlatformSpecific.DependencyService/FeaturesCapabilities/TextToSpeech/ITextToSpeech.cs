using System;
using System.Collections.Generic;

namespace PlatformSpecific.DependencyService.FeaturesCapabilities.TextToSpeech
{
	public interface ITextToSpeech
	{
		void Speak(string text);
	}
}
