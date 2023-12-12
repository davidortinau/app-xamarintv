using System.Globalization;

namespace XamarinTV.Converters
{
    public class VideoSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (String.IsNullOrWhiteSpace(value.ToString()))
                return null;

            if(DeviceInfo.Platform == DevicePlatform.WinUI)
                return new Uri($"ms-appx:///Assets/{value}");
            else
                return new Uri($"ms-appx:///{value}");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
