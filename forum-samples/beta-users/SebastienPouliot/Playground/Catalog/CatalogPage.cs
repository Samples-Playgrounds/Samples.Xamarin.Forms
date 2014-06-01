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
using System.Collections;
using Xamarin.QuickUI;

namespace QuickDemo {

	public class CatalogPage : ContentPage {

		public CatalogPage (IEnumerable source)
		{
			Title = "All";
			var listview = new ListView () {
				ItemSource = source,
				//ItemTemplate = new DataTemplate (typeof (StarCell), null, null)
				ItemTemplate = DataTemplate<Cell>.Create (() => (Cell) new StarCell (), null),
			};
			listview.ItemSelected += (object sender, EventArg<object> e) => Navigation.Push (new StarPage () {
				BindingContext = e.Data
			});
			Content = listview;
		}

		public static Page GetMainPage ()
		{
			return new NavigationPage (new CatalogPage (new StarDataSource ()));
		}		
	}
}