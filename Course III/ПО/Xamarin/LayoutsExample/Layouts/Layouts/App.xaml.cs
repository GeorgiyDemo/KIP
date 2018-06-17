using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

/*
Layout<T>
StackLayout
AbsoluteLayout
RelativeLayout
Grid

*/
namespace Layouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Layouts.MainPage();
            //MainPage = new Layouts.Absolute();
            //MainPage = new Layouts.Relative();
            MainPage = new Layouts.GridLayout();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
