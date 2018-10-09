using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechToText.DependencyService.TextToSpeech
{
	/// <summary>
	/// 
	/// </summary>
	/// <see cref="http://www.politepix.com/openears/"/>
	/// <see cref="http://www.ispeech.org/#/home"/>
	/// <see cref="https://github.com/jhurt/GIRI"/>
	public interface ITextToSpeechService
	{
		string RecordVoice();

	}
}
