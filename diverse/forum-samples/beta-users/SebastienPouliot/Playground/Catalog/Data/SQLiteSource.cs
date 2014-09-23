//
// Authors:
//	Jeffrey Stedfast <jeff@xamarin.com>
//	Sebastien Pouliot  <sebastien@xamarin.com>
// 
// Copyright (c) 2012-2013 Xamarin Inc.
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
using System.Collections.Generic;
using MonoTouch.SQLite;

namespace QuickDemo {

	public abstract class SQLiteReadOnlyDataSource<T> : VirtualList where T : class, new () {

		static readonly object[] Empty = new object [0];

		int offset;
		int PageSize = 16;
		List<T> cache = new List<T> (32);

		protected SQLiteReadOnlyDataSource ()
		{
		}

		public SQLiteConnection Connection { get; set; }

		public string Query { get; set; }

		protected SQLiteCommand CreateQueryCommand (int limit, int offset)
		{
			string command = Query + " limit " + limit + " offset " + offset;
			return Connection.CreateCommand (command, Empty);
		}

		public override object this [int index] {
			get { return GetDataFor (index); }
			set { throw new NotSupportedException (); }
		}

		T GetDataFor (int index)
		{
			int limit = PageSize;

			if (index < 0)
				return null;

			//Connection.Trace = true;

			if (index == offset - 1) {
				// User is scrolling up. Fetch the previous page of items...
				int first = Math.Max (offset - PageSize, 0);

				// Calculate the number of items we need to fetch...
				limit = offset - first;

				// Calculate the number of items we need to uncache...
				int rem = limit - ((2 * PageSize) - cache.Count);

				if (rem > 0)
					cache.RemoveRange (cache.Count - rem, rem);

				var cmd = CreateQueryCommand (limit, first);
				var results = cmd.ExecuteQuery<T> ();

				// Insert our new items at the head of our cache list...
				cache.InsertRange (0, results);
				offset = first;
			} else if (index == offset + cache.Count) {
				// User is scrolling down. Fetch the next page of items...
				if (cache.Count > PageSize)
					cache.RemoveRange (0, cache.Count - PageSize);

				// Load 2 pages if we are at the beginning
				if (index == 0)
					limit = 2 * PageSize;

				var cmd = CreateQueryCommand (limit, index);
				var results = cmd.ExecuteQuery<T> ();

				offset = Math.Max (index - PageSize, 0);
				cache.AddRange (results);
			} else if (index < offset || index > offset + cache.Count) {
				// User is requesting an item in the middle of no-where...
				// align to the page enclosing the given index.
				// Note: this only works if PageSize is a power of 2.
				//int first = ((index + (PageSize - 1)) & ~(PageSize - 1)) - PageSize;
				int first = (index / PageSize) * PageSize;

				limit = 2 * PageSize;
				cache.Clear ();

				var cmd = CreateQueryCommand (limit, first);
				var results = cmd.ExecuteQuery<T> ();
				cache.AddRange (results);
				offset = first;
			}

			//Connection.Trace = false;

			index -= offset;
			if (index < cache.Count)
				return cache[index];

			return null;
		}
	}
}