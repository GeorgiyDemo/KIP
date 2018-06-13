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
	public partial class BrowserString : ContentPage
	{
		public BrowserString ()
		{
            //InitializeComponent ();
            WebView wv = new WebView();
            var html = new HtmlWebViewSource();
            html.Html = @"
                <html>
                <body>
                    <h1>Hello from WebView</h1>
                    <p>Привет из движка WebView</p>
                </body>
                </html>

";

            wv.Source = html;
            this.Content = wv;
		}
	}
}