using System;
using System.Globalization;
using Xamarin.Forms;

namespace XFlImageButtonListView.Converter
{
    /// <summary>
    /// Método responsável em Exibir icone no botão, através de uma regra de negócio
    /// </summary>
    public class ImageViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Valida regra de negócio para exibir imagem no botão
            if(value.ToString().Equals("Nome1"))
                //Exibe imagem para cada platforma.
                return Device.OnPlatform<String>("callanswerIOS.png", "callanswer.png", "img/callanswerUWP.png");
            else
                //Exibe imagem para cada platforma.
                return Device.OnPlatform<String>("pointingdownIOS.png", "pointingdown.png", "img/pointingdownUWP.png");

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Volta a imagem padrão para cada platforma.
            return Device.OnPlatform<String>("pointingdownIOS.png", "pointingdown.png", "img/pointingdownUWP.png");
        }
    }
}
