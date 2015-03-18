using System;
using System.ComponentModel;

using UIKit;
using CoreGraphics;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using CustomRenderers.CustomControls;
using CustomRenderers.CustomRenderers.XamarinIOS;

[assembly: 
	Xamarin.Forms.ExportRenderer
				(
					typeof(BoxViewRoundedCorners),			// custom control rendered from shared/coommon
					typeof(BoxViewRoundedCornersRenderer)	// renderer
				)
]

namespace CustomRenderers.CustomRenderers.XamarinIOS
{
	public class BoxViewRoundedCornersRenderer 
		: 
		Xamarin.Forms.Platform.iOS.BoxRenderer
		// 	derives from:
		//		VisualElementRenderer<BoxView>
		//	derives from:
		//		VisualElementRenderer<TElement>
		//	derives from
		//		UIView
	{
		public BoxViewRoundedCornersRenderer ()
		{
			//this.SetWillNotDraw(false);

			return;
		}
			
		public override void Draw (CGRect rect)
        {
			BoxViewRoundedCorners cbv = (BoxViewRoundedCorners)Element;

            using (var context = UIGraphics.GetCurrentContext ()) 
            {
                context.SetFillColor (cbv.FillColor.ToCGColor());
                context.SetStrokeColor (cbv.StrokeColor.ToCGColor ());
                context.SetLineWidth ((float)cbv.StrokeThickness);

                CoreGraphics.CGRect rc = this.Bounds.Inset ((nint)cbv.StrokeThickness, (nint)cbv.StrokeThickness);

                nfloat radius = (nfloat)cbv.CornerRadius;
                //radius = (nfloat)Math.Max (0, Math.Min (radius, Math.Max ((float)rc.Height / 2, (float)rc.Width / 2)));

                CGPath strokePath = CGPath.FromRoundedRect (rc, radius, radius);
                context.AddPath (strokePath);
                context.DrawPath (CGPathDrawingMode.FillStroke);

				if (cbv.HasShadow) 
				{
					NativeView.Layer.ShadowColor = UIColor.Black.CGColor;
					NativeView.Layer.ShadowOffset = new System.Drawing.SizeF(3, 3);
					NativeView.Layer.ShadowOpacity = 1;
					NativeView.Layer.ShadowRadius = 5;
				}
				else 
				{
					NativeView.Layer.ShadowColor = UIColor.Clear.CGColor;
					NativeView.Layer.ShadowOffset = new System.Drawing.SizeF();
					NativeView.Layer.ShadowOpacity = 0;
					NativeView.Layer.ShadowRadius = 0;
				}

            }

            return;
        }

		protected override void OnElementPropertyChanged (object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);

			string property_name = e.PropertyName;
			if 
			(
				property_name == BoxViewRoundedCorners.CornerRadiusProperty.PropertyName
				||
				property_name == BoxViewRoundedCorners.StrokeColorProperty.PropertyName
				||
				property_name == BoxViewRoundedCorners.StrokeThicknessProperty.PropertyName
				||
				property_name == BoxViewRoundedCorners.HasShadowProperty.PropertyName
			) 
			{
				this.SetNeedsDisplay();
			}

			return;
		}
	}
}

