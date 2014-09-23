//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
// 
// Copyright (c) 2013 Xamarin Inc.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 

using System;
using Xamarin.QuickUI;

#if __IOS__
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.QuickUI.Platform.iOS;
#endif

namespace QuickDemo {

	public class StarCell : TextCell {

		public static readonly BindableProperty FlagsProperty;

		static StarCell ()
		{
			FlagsProperty = BindableProperty.Create<StarCell> ((StarCell c) => c.Flags, (byte) 0, BindingMode.OneWay, null, null, null, null);
		}

		public StarCell ()
		{
			Style = TextCellStyle.Vertical;
			SetBinding (TextCell.TextProperty, new Binding ("Name"));
			SetBinding (TextCell.DetailProperty, new Binding ("Position"));
			SetBinding (StarCell.FlagsProperty, new Binding ("Flags"));
		}

		public byte Flags {
			get {
				return (byte)base.GetValue (StarCell.FlagsProperty);
			}
			set {
				base.SetValue (StarCell.FlagsProperty, value);
			}
		}
	}

#if __IOS__
	// get the look closer to the existing application
	class StarCellRenderer : TextCellRenderer {

		static UIImage icon_variable;
		public static UIImage GetVariable ()
		{
			if (icon_variable == null)
				icon_variable = GetIcon ("V", 0.4f, 0.6f, 0.4f, 1.0f);
			return icon_variable;
		}

		static UIImage icon_suspect;
		public static UIImage GetSuspect ()
		{
			if (icon_suspect == null)
				icon_suspect = GetIcon ("S", 0.8f, 0.4f, 0.4f, 1.0f);
			return icon_suspect;
		}

		static UIImage icon_non_variable;
		public static UIImage GetNonVariable ()
		{
			if (icon_non_variable == null)
				icon_non_variable = GetIcon ("N", 0.6f, 0.6f, 0.6f, 1.0f);
			return icon_non_variable;
		}

		static UIImage GetIcon (string letter, float r, float g, float b, float a)
		{
			const float size = 40f;
			UIGraphics.BeginImageContextWithOptions (new SizeF (size, size), false, 0.0f);
			using (var c = UIGraphics.GetCurrentContext ()) {
				c.SetFillColor (r, g, b, a);
//				GraphicsUtil.FillRoundedRect (c, new RectangleF (2, 2, size - 4, size - 4), 6);
				c.FillRect (new RectangleF (2, 2, size - 4, size - 4));
				c.SetFillColor (1, 1, 1, 1);
				c.SetStrokeColor (1, 1, 1, 1);
				UIFont font = UIFont.BoldSystemFontOfSize (size - 8);
				using (var s = new NSString (letter))
					s.DrawString (new PointF (9f, 2f), font);
			}
			UIImage img = UIGraphics.GetImageFromCurrentImageContext ();
			UIGraphics.EndImageContext ();
			return img;
		}

		public UIImage GetImage (byte flags)
		{
			if (flags == 1)
				return GetSuspect ();
			else if (flags == 2)
				return GetNonVariable ();
			else
				return GetVariable ();
		}

		public override UITableViewCell GetCell (Cell item, UITableView tv)
		{
			var c = base.GetCell (item, tv);
			tv.SeparatorStyle = UITableViewCellSeparatorStyle.None;
			c.ImageView.Image = GetImage ((item as StarCell).Flags);
			c.SelectionStyle = UITableViewCellSelectionStyle.Gray;

			c.TextLabel.LineBreakMode = UILineBreakMode.TailTruncation;
			c.TextLabel.Lines = 1;
			c.Accessory = UITableViewCellAccessory.DisclosureIndicator;
			return c;
		} 
	}
#endif
}