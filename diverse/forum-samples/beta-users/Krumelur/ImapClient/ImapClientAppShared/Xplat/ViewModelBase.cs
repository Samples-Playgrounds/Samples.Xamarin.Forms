using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Xplat_Core
{
	/// <summary>
	/// Base class for all view models. This supports validation, setting the model in a "busy" mode and allows to collect errors.
	/// </summary>
	public class ViewModelBase : PropertyChangedBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Xplat_Core.ViewModelBase"/> class.
		/// </summary>
		public ViewModelBase ()
		{
			this.errors = new List<ViewModelError> ();
			this.Validate ();
		}

		private readonly List<ViewModelError> errors;

		/// <summary>
		/// Gets a value indicating whether the model is in a valid state, meaning there are no errors.
		/// </summary>
		public virtual bool IsValid
		{
			get
			{
				return this.errors.Count <= 0;
			}
		}

		/// <summary>
		/// Gets the errors.
		/// </summary>
		/// <value>The errors.</value>
		protected IEnumerable<ViewModelError> Errors
		{
			get
			{
				return this.errors;
			}
		}

		/// <summary>
		/// Occurs when validity of the model has changed.
		/// </summary>
		public event EventHandler IsValidChanged;

		/// <summary>
		/// Occurs when the busy state of the model has changed.
		/// </summary>
		public event EventHandler IsBusyChanged;

		/// <summary>
		/// Validates the model.
		/// </summary>
		protected virtual void Validate()
		{
			OnPropertyChanged ("IsValid");
			OnPropertyChanged ("Errors");

			var callback = this.IsValidChanged;
			if(callback != null)
			{
				callback(this, EventArgs.Empty);
			}

			// Spit out errors for easier debugging.
			if(this.errors != null && this.errors.Count > 0)
			{
				Console.WriteLine ("Errors:");
				foreach(var error in this.errors)
				{
					Console.WriteLine (error);
				}
			}
		}

		/// <summary>
		/// Validates a property. If validation fails, adds an error.
		/// </summary>
		/// <param name="validate">Validate.</param>
		/// <param name="error">Error.</param>
		protected virtual void ValidateProperty(Func<bool> validate, ViewModelError error)
		{
			if(validate())
			{
				this.errors.Remove (error);
			}
			else if(!this.errors.Contains(error))
			{
				this.errors.Add (error);
			}
		}

		/// <summary>
		/// Value inidicating if a spinner should be shown
		/// </summary>
		public virtual bool IsBusy
		{
			get { return this.isBusy; }
			set
			{
				if (this.isBusy != value) {
					this.isBusy = value;

					this.OnPropertyChanged ("IsBusy");
					this.OnIsBusyChanged ();
				}
			}
		}
		private bool isBusy = false;

		/// <summary>
		/// Other viewmodels can override this if something should be done when busy
		/// </summary>
		protected virtual void OnIsBusyChanged ()
		{
			// Some models might want to have a validation thet depends on the busy state.
			this.Validate ();
			var method = IsBusyChanged;
			if (method != null)
				IsBusyChanged (this, EventArgs.Empty);
		}
	}
}

