using System;

namespace PlatformSpecific.DependencyService
{
	public interface ISpeechToTextService
	{
		bool IsMicrophoneAvailable
		{
			get;
		}
	}
}

