using System;
using System.Windows.Input;

namespace Xplat_Core
{
	/// <summary>
	/// Implements ICommand using delegates for simpler usage.
	/// </summary>
	public class DelegateCommand : ICommand
	{
		readonly Predicate<object> canExecute;
		readonly Action<object> execute;

		public event EventHandler CanExecuteChanged;

		public DelegateCommand(Action<object> execute) 
			: this(execute, null)
		{
		}

		public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
		{
			this.execute = execute;
			this.canExecute = canExecute;
		}

		public bool CanExecute(object parameter)
		{
			if (this.canExecute == null)
			{
				return true;
			}

			return this.canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			this.execute(parameter);
		}

		public void RaiseCanExecuteChanged()
		{
			var handler = this.CanExecuteChanged;
			if( handler != null )
			{
				handler(this, EventArgs.Empty);
			}
		}
	}
}

