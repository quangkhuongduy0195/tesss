using System;
using System.Globalization;
using Xamarin.Forms;
namespace Views.Converter
{
    public class LabelConvertFontSize:IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var incomingSize = (double)parameter;
            double outgoingSize = incomingSize;
            if (Base.WidthScreen > 320)
            {
                outgoingSize += 1.29375;
            }
            return outgoingSize;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
