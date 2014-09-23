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
using MonoTouch.SQLite;

namespace QuickDemo {

	public class StarDataSource : SQLiteReadOnlyDataSource <StarEntry> {

		public StarDataSource ()
		{
#if __IOS__
			// we can use the readonly copy we ship with the application
			string db = "vstars.sqlite";
#elif __ANDROID__
			// we need to use a copy of the asset with ship with the application
			string documentPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			string db = System.IO.Path.Combine (documentPath, "vstars.sqlite");
#endif
			Connection = new SQLiteConnection (db, SQLiteOpenFlags.ReadOnly);
			Query = "select * from StarEntry order by SortName";
		}

		// is's a read-only database shipped with the application
		// so we always know how many records there is
		public override int Count {
			get { return 1327; }
		}
	}
}