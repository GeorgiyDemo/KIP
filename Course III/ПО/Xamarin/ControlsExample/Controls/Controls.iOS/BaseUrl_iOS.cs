using Foundation;

using Xamarin.Forms;

[assembly: Dependency(typeof(Controls.iOS.BaseUrl_iOS))]
namespace Controls.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string GetBaseUrl()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}