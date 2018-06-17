using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;

[assembly: Dependency(typeof(Controls.Droid.BaseUrl_Android))]
namespace Controls.Droid
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string GetBaseUrl()
        {
            return "file:///android_asset/";
        }
    }
}