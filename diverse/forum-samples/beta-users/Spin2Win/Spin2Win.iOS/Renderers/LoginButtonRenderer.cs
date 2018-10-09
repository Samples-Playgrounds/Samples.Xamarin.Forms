using Xamarin.QuickUI;
using Xamarin.QuickUI.Platform.iOS;
using MonoTouch.UIKit;
using Spin2Win;

[assembly: ExportRendererAttribute(typeof (LoginButton), typeof (LoginButtonRenderer))]
namespace Spin2Win
{
	public class LoginButtonRenderer : ButtonRenderer 
	{
		protected override void OnModelSet (View view)
		{
			base.OnModelSet (view);
			var button = (UIButton)Control;

			button.SetTitleColor (UIColor.White, UIControlState.Normal);
			button.TitleLabel.Font = UIFont.FromName ("HelveticaNeue-UltraLight", 60);
			button.Layer.BorderColor = UIColor.White.CGColor;
			button.Layer.CornerRadius = 5;
			button.Layer.BorderWidth = 2;
		}
	}
}