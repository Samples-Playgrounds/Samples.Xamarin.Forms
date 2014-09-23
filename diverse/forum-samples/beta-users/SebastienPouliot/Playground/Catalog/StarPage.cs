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

namespace QuickDemo {

	public class StarPage : ContentPage {

		ToolbarItem fav_on;
		ToolbarItem fav_off;

		public StarPage ()
		{
			fav_on = new ToolbarItem ("on", null, () => {
				// this gets called but the ToolbarItems is not updated
				// and every "click" goes back here
				ToolbarItems.Remove (fav_on);
				ToolbarItems.Add (fav_off);
			});
			fav_off = new ToolbarItem ("off", null, () => {
				// so this nevers get called
				ToolbarItems.Remove (fav_off);
				ToolbarItems.Add (fav_on);
			});
			ToolbarItems.Add (fav_on);

			SetBinding (Page.TitleProperty, new Binding ("Name"));
		}
	}
}