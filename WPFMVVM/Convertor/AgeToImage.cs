using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace WPFMVVM.Convertor
{
    class AgeToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int.TryParse(value.ToString(), out int age);
            if(age < 18)
            {
                return "/Images/child.png";
            }
            else if (age >= 18 && age < 60)
            {
                return "/Images/adult.png";
            }
            else
            {
                return "/Images/senior.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
