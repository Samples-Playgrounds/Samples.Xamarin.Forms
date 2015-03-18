using System;

using System.Collections;

namespace Core.Collections
{
	public static class EnumerableExtensions
	{
		/// <summary>
		/// Returns the index of the specified object in the collection.
		/// </summary>
		/// <param name="self">The self.</param>
		/// <param name="obj">The object.</param>
		/// <returns>If found returns index otherwise -1</returns>
		public static int IndexOf(this IEnumerable self, object obj)
		{
			int index = -1;

			var enumerator = self.GetEnumerator();
			enumerator.Reset();
			int i = 0;
			while (enumerator.MoveNext())
			{
			    if (enumerator.Current.Equals(obj))
			    {
			        index = i;
			        break;
			    }

			    i++;
			}

			return index;
		}
	}
}

