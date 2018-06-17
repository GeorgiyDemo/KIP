using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Controls
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myDate.MinimumDate = DateTime.Today.AddMonths(-1);
            myDate.MaximumDate = DateTime.Today.AddMonths(1);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.myButton.Text = this.loginEntry.Text;

        }

        private void loginEntry_TextChanged(object sender,
            TextChangedEventArgs e)
        {
            eventInfo.Text = string.Format("{0} -> {1}",
                e.OldTextValue, e.NewTextValue);

            //Keyboard.
        }

        private void myDate_DateSelected(object sender, DateChangedEventArgs e)
        {
            eventInfo.Text = string.Format("Selected Date: {0}",
                e.NewDate);
        }

        private void langPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Picker p = sender as Picker;
            //this.langPicker
            eventInfo.Text = string.Format("Preferred lang: {0}",
                langPicker.SelectedItem.ToString()
                );


        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            eventInfo.Text = string.Format("Stepper value: {0:F1}", e.NewValue);
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            eventInfo.Text = string.Format("switch toggled to: {0}",
                e.Value);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await DisplayAlert("Notification", "You have a new message", "OK");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Confirm", "Remove item?", "Yes", "No");
            eventInfo.Text = result.ToString();
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            string action = 
                await DisplayActionSheet("Send to", "Cancel", "Send", "Facebook", "VK", "OK");

            eventInfo.Text = action;
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            /*Device.StartTimer(TimeSpan.FromSeconds(3),
                () =>
                {
                    DisplayAlert("Info", "3 seconds passed", "ok");
                    return false;
                });*/

            await Task.Delay(3000);
            await DisplayAlert("Info", "3 seconds passed", "ok");

        }
    }
}
