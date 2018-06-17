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
    public partial class Absolute : ContentPage
    {
        public Absolute()
        {
            InitializeComponent();
            //AbsoluteLayout al = new AbsoluteLayout();
            /*al.Children.Add(
                new Label
                {
                    Text = "Мой Заголовк",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                }
                ,new Rectangle(50, 60, 200, 50)
            );*/
            /*
            Label l1 = new Label
            {
                Text = "Мой Заголовк",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            AbsoluteLayout.SetLayoutBounds(l1, new Rectangle(50, 60, 200, 50));
            al.Children.Add(l1);



            al.Children.Add(
                new Label
                {
                    Text = "Основное содержимое страницы",
                    FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
                },
                new Point(20, 200)
            );

            Content = al;*/


        }
    }
}