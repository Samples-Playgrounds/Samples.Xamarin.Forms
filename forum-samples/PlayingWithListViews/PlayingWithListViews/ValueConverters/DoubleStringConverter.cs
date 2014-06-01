using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.QuickUI;

namespace PlayingWithListViews.ValueConverters
{

    public class DoubleStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (null == value || "0" == value.ToString())
                return string.Empty;
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double? returnValue = null;
            double convertResult;
            var strvalue = value as string;
            if (double.TryParse(strvalue, out convertResult))
            {
                returnValue = convertResult;
            }
            return returnValue;
        }
    }
}