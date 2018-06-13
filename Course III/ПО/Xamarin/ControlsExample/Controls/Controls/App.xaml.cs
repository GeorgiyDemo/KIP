using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Controls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Controls.MainPage();
            //MainPage = new Controls.Images();
            //MainPage = new Controls.TableViewPage();
            //MainPage = new Controls.Browser();
            //MainPage = new Controls.BrowserString();
            //MainPage = new Controls.BrowserLocal();
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
