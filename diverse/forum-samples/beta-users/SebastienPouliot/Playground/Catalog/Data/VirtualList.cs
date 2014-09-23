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

namespace QuickDemo {

	// IEnumerator is not efficient for browsing a large database (that does not fit in memory)
	// QuickUI has optimizations that detect an `IList` (and avoid creating it's own)

	public abstract class VirtualList : IList, IEnumerator {

		int position;

		// IList

		public virtual bool IsFixedSize {
			get { return true; }
		}

		public virtual bool IsReadOnly {
			get { return true; }
		}

		public abstract object this [int index] { get; set; }

		public virtual int Add (object value)
		{
			throw new NotSupportedException ();
		}

		public virtual void Clear ()
		{
			throw new NotSupportedException ();
		}

		public virtual bool Contains (object value)
		{
			throw new NotImplementedException ();
		}

		public virtual int IndexOf (object value)
		{
			throw new NotImplementedException ();
		}

		public virtual void Insert (int index, object value)
		{
			throw new NotSupportedException ();
		}

		public virtual void Remove (object value)
		{
			throw new NotSupportedException ();
		}

		public virtual void RemoveAt (int index)
		{
			throw new NotSupportedException ();
		}

		// ICollection

		public abstract int Count { get; }

		public bool IsSynchronized {
			get { return false; }
		}

		public object SyncRoot {
			get { return this; }
		}

		public void CopyTo (Array array, int index)
		{
			throw new NotImplementedException ();
		}

		// IEnumerable

		public IEnumerator GetEnumerator ()
		{
			Reset ();
			return this;
		}

		public object Current {
			get { return this [position]; }
		}

		public bool MoveNext ()
		{
			position++;
			return (position < Count);
		}

		public void Reset ()
		{
			position = -1;
		}
	}
}