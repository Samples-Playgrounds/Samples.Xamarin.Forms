//
// Authors:
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
using MonoTouch.SQLite;

#if __IOS__
using MonoTouch.Foundation;
#endif

namespace QuickDemo {

	[Preserve (AllMembers = true)]
	public partial class StarEntry {
		[PrimaryKey]
		// case insensitive name as key ?
		// vsx: A30 gcvs: A10 nsv: 9 (prefix + I5) evs: A12
		[MaxLength (30)]
		public string Name { get; set; }

		[Indexed]
		public int Oid { get; set; }

		[MaxLength (8)]
		public string RA { get; set; }
		[MaxLength (7)]
		public string Dec { get; set; }

		public byte Flags { get; set; }
		public byte Constellation { get; set; }

		[Ignore] // for binding support, not part of the database
		public string Position { get { return RA + " " + Dec; } }


		public override bool Equals (object obj)
		{
			StarEntry entry = obj as StarEntry;
			return (entry != null && entry.Oid == Oid);
		}

		public override int GetHashCode ()
		{
			return Oid;
		}
	}
}