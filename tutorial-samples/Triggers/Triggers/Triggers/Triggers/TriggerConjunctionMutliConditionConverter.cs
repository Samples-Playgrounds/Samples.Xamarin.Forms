using System;
using System.Globalization;

using Xamarin.Forms;

namespace Triggers
{
	public partial class TriggerConjunctionMutliConditionConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((int)value > 0) // length > 0 ?
			    return true;            // some data has been entered
			else
			    return false;           // input is empty
		}

	    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	    {
	        throw new NotSupportedException ();
	    }
	}
}

