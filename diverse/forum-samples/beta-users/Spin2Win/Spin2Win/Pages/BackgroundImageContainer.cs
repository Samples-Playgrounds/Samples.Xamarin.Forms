using Xamarin.QuickUI;

namespace Spin2Win
{
	public class BackgroundImageContainer : AbsoluteLayout
	{
		private ContentView content = new ContentView ();

		public View Content
		{
			get { return content.Content; }
			set { content.Content = value; }
		}

		public BackgroundImageContainer (string file)
		{
			var background = new Image {
				Source = file
			};

			SetNormalizedSize(background, true, 1, 1);
			Add(background);

			SetNormalizedSize (content, true, 1, 1);
			Add(content);
		}
	}
}