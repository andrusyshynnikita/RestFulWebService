using MvvmCross.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace RestFulWebService.Converters
{
   public class PressureToStringConverter : MvxValueConverter<double>

    {
        protected override object Convert(double value, Type targetType, object parameter, CultureInfo culture)
        {

            return value.ToString() + " hpa";
        }
    }
}
