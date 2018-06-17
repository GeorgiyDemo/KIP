using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

[assembly: Dependency(typeof(Controls.UWP.BaseUrl_UWP))]
namespace Controls.UWP
{
    class BaseUrl_UWP : Controls.IBaseUrl
    {
        public string GetBaseUrl()
        {
            return "ms-appx-web:///";
        }
    }
}
