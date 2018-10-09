using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Xplat_Core
{
	/// <summary>
	/// Simplifies INPC by using the CallerMemberNameAttribute. Note that this is not compatible with PCL but works with file linking only.
	/// </summary>
	public class PropertyChangedBase : INotifyPropertyChanged
	{
		private Dictionary<string, object> properties = new Dictionary<string, object> ();

		/// <summary>
		/// Gets the value of a property
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="name"></param>
		protected T GetProperty<T> ([CallerMemberName] string name = null)
		{
			object value = null;
			if (this.properties.TryGetValue (name, out value))
			{
				return value == null ? default(T) : (T)value;
			}
			return default(T);
		}

		/// <summary>
		/// Sets the value of a property
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="value"></param>
		/// <param name="name"></param>
		protected void SetProperty<T> (T value, [CallerMemberName] string name = null)
		{
			if (Equals (value, this.GetProperty<T> (name)))
			{
				return;
			}
			this.properties [name] = value;
			OnPropertyChanged (name);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged ([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler (this, new PropertyChangedEventArgs (propertyName));
			}
		}
	}
}