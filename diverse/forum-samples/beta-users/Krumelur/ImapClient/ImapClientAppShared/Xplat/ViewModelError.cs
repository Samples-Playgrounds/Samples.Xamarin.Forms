using System;

namespace Xplat_Core
{
	/// <summary>
	/// Encapsulates an error in a view model.
	/// TODO: This should be injectable to allow the view model to create the user's desired error objects.
	/// </summary>
	public class ViewModelError
	{
		public ViewModelError (string text)
		{
			this.Text = text;
		}

		public string Text
		{
			get;
			set;
		}

		public override bool Equals (object obj)
		{
			var error = obj as ViewModelError;
			if(error == null)
			{
				return false;
			}
			return this.Text.Equals (error.Text);
		}

		public override int GetHashCode ()
		{
			return this.Text.GetHashCode ();
		}

		public override string ToString ()
		{
			return string.Format("ViewModelError: {0}", this.Text);
		}
	}
}

