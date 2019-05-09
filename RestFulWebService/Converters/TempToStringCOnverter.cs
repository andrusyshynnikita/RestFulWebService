using MvvmCross.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RestFulWebService.Converters
{
   public class TempToStringConverter : MvxValueConverter<double>

    {
        protected override object Convert(double value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = (int)value;
            return result.ToString() + " °C";
        }
    }
}
