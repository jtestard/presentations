using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace DataBinding
{
    public class DateConverter : IValueConverter
    {

        public object Convert( 
            object value, 
            Type targetType, 
            object parameter, 
            System.Globalization.CultureInfo culture )
        {
            if (targetType == typeof( string ) &&
                value.GetType() == typeof( DateTime ))
            {
                return (( DateTime ) value).ToShortDateString();
            }
            else  // unable to convert
            {
                return value;
            }
        }

        public object ConvertBack( 
            object value, 
            Type targetType, 
            object parameter, 
            System.Globalization.CultureInfo culture )
        {
            throw new NotImplementedException();
        }
    }
}
