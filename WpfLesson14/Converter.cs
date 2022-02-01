using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfLesson14
{
    class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((int)value)==1)
                    {
                return "Image/1.png";
            }
            else if (((int)value)==2)
            {
                return "Image/2.png";
            }
            else
            {
                return "Image/3.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return DependencyProperty.UnsetValue;
        }
    }
}
