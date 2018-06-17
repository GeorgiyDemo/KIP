using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayout : ContentPage
    {
        public GridLayout()
        {
            InitializeComponent();
            //new GridLength(1, GridUnitType.Star)
            //Color.FromRgba
        }
    }
}