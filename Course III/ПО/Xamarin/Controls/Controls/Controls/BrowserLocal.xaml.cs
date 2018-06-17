using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BrowserLocal : ContentPage
	{
		public BrowserLocal ()
		{
            //InitializeComponent ();
            WebView wv = new WebView();
            UrlWebViewSource urlSource= new UrlWebViewSource();
            //urlSource.Url = "file:///android_asset/page.html";
            //urlSource.Url = "ms-appx-web:///page.html";
            urlSource.Url  = Path.Combine(
                DependencyService.Get<IBaseUrl>().GetBaseUrl(),
                "page.html");
            wv.Source = urlSource;
            this.Content = wv;



        }
	}
}