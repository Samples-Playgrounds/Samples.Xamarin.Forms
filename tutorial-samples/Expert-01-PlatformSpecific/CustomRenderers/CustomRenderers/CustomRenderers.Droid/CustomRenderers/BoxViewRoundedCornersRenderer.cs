using System;

using Android.Graphics;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using CustomRenderers.CustomControls;
using CustomRenderers.CustomRenderers.XamarinAndroid;

[assembly: 
	Xamarin.Forms.ExportRenderer
				(
					typeof(BoxViewRoundedCorners),			// custom control rendered from shared/coommon
					typeof(BoxViewRoundedCornersRenderer)	// renderer
				)
]

namespace CustomRenderers.CustomRenderers.XamarinAndroid
{
	public class BoxViewRoundedCornersRenderer
		: 
		Xamarin.Forms.Platform.Android.BoxRenderer
		// 	derives from:
		//		VisualElementRenderer<BoxView>
		//	derives from:
		//		VisualElementRenderer<TElement>
		//	derives from
		//		UIView

	{
		public BoxViewRoundedCornersRenderer ()
		{
			this.SetWillNotDraw(false);

			return;
		}

    	public override void Draw(Canvas canvas)
		{
			BoxViewRoundedCorners rbv = (BoxViewRoundedCorners)this.Element;

			Rect rc = new Rect();
			GetDrawingRect(rc);

			Rect interior = rc;
			interior.Inset((int)rbv.StrokeThickness, (int)rbv.StrokeThickness);

			Paint p = new Paint() 
			{
				Color = rbv.FillColor.ToAndroid(),
				AntiAlias = true,
			};

			canvas.DrawRoundRect(new RectF(interior), (float)rbv.CornerRadius, (float)rbv.CornerRadius, p);

			p.Color = rbv.StrokeColor.ToAndroid();
			p.StrokeWidth = (float)rbv.StrokeThickness;
			p.SetStyle(Paint.Style.Stroke);

			canvas.DrawRoundRect(new RectF(rc), (float)rbv.CornerRadius, (float)rbv.CornerRadius, p);

			return;
		}

		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if 
			(
				e.PropertyName == BoxViewRoundedCorners.CornerRadiusProperty.PropertyName
				||
				e.PropertyName == BoxViewRoundedCorners.StrokeColorProperty.PropertyName
				||
				e.PropertyName == BoxViewRoundedCorners.StrokeThicknessProperty.PropertyName
				||
				e.PropertyName == BoxViewRoundedCorners.HasShadowProperty.PropertyName
			) 
			{
				this.Invalidate ();
			}

			return;
		}
	}
}

