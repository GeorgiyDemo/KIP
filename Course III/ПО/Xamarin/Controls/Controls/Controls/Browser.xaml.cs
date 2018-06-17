using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Browser : ContentPage
	{
		public Browser ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(urlEntry.Text))
            {
                string url = urlEntry.Text.Trim();
                if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                    url = "http://" + url;

                myWebView.Source = new UrlWebViewSource { Url = url };
            }

        }
    }
}