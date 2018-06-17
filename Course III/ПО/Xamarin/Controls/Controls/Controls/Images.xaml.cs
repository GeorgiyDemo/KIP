using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Controls
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Images : ContentPage
    {
        public Images()
        {
            //InitializeComponent();
            //Image myImage = new Image { Source = "logo.jpg" };
            //Image myImage = new Image();
            //myImage.Source = ImageSource.FromResource("Images.logo.jpg");

            //this.Content = myImage;


            /*
            Image myImage = new Image();
            myImage.Source = Device.OnPlatform<ImageSource>(
                WinPhone: ImageSource.FromFile("Images/logo.jpg"),
                Android: ImageSource.FromFile("logo.jpg"),
                iOS: ImageSource.FromFile("logo.jpg")
                );*/

            Image myImage = new Image();
            myImage.Source = new UriImageSource
            {
                Uri = new Uri("https://images.vexels.com/media/users/3/139556/isolated/preview/1718a076e29822051df8bcf8b5ce1124-android-logo-by-vexels.png"),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(2, 0, 0, 0)
            };

            myImage.Aspect = Aspect.AspectFill;

            this.Content = myImage;
        }
    }
}