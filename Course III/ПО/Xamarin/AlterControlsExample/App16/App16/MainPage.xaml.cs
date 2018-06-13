using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App16
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        void Button_Click(object sender, EventArgs e)
        {
            this.MyButton.Text = "Pressed";
        }
        private void loginEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            eventInfo.Text = string.Format("{0} -> {1}",e.OldTextValue, e.NewTextValue);
        }
        private void myDate_DateSelected(object sender, DateChangedEventArgs e)
        {
            eventInfo.Text = string.Format("Selected Date: {0}",e.NewDate);
        }

        private void langPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Picker p = sender as Picker;
            //this.langPicker
            eventInfo.Text = string.Format("Preferred lang: {0}",langPicker.SelectedItem.ToString());
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


    }
}
