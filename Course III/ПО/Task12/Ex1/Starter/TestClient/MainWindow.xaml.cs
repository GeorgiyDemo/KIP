using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initiate the reactor shutdown using a Switch object
        /// Record details of shutdown status in a TextBlock - recording all exceptions thrown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.textBlock1.Text = "Initiating test sequence: " + DateTime.Now.ToLongTimeString();
            SwitchDevices.Switch sd = new SwitchDevices.Switch();

            // Step 1 - disconnect from the Power Generator

            try
            {

                if (sd.DisconnectPowerGenerator() == SwitchDevices.SuccessFailureResult.Fail)
                {
                    this.textBlock1.Text += "\nStep 1: Failed to disconnect power generation system";
                }
                else
                {
                    this.textBlock1.Text += "\nStep 1: Successfully disconnected power generation system";
                }
            }
            catch (SwitchDevices.PowerGeneratorCommsException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 1: " + ex.Message;
            }


            // Step 2 - Verify the status of the Primary Coolant System

            try
            {
                switch (sd.VerifyPrimaryCoolantSystem())
                {
                    case SwitchDevices.CoolantSystemStatus.OK:
                        this.textBlock1.Text += "\nStep 2: Primary coolant system OK";
                        break;
                    case SwitchDevices.CoolantSystemStatus.Check:
                        this.textBlock1.Text += "\nStep 2: Primary coolant system requires manual check";
                        break;
                    case SwitchDevices.CoolantSystemStatus.Fail:
                        this.textBlock1.Text += "\nStep 2: Problem reported with primary coolant system";
                        break;
                }
            }
            catch (SwitchDevices.CoolantPressureReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 2: " + ex.Message;
            }
            catch (SwitchDevices.CoolantTemperatureReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 2: " + ex.Message;
            }


            // Step 3 - Verify the status of the Backup Coolant System
            try
            {

                switch (sd.VerifyBackupCoolantSystem())
                {
                    case SwitchDevices.CoolantSystemStatus.OK:
                        this.textBlock1.Text += "\nStep 3: Backup coolant system OK";
                        break;
                    case SwitchDevices.CoolantSystemStatus.Check:
                        this.textBlock1.Text += "\nStep 3: Backup coolant system requires manual check";
                        break;
                    case SwitchDevices.CoolantSystemStatus.Fail:
                        this.textBlock1.Text += "\nStep 3: Backup reported with primary coolant system";
                        break;
                }
            }
            catch (SwitchDevices.CoolantPressureReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 3: " + ex.Message;
            }
            catch (SwitchDevices.CoolantTemperatureReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 3: " + ex.Message;
            }


            // Step 4 - Record the core temperature prior to shutting down the reactor
            try
            {
                this.textBlock1.Text += "\nStep 4: Core temperature before shutdown: " + sd.GetCoreTemperature();
            }
            catch (SwitchDevices.CoreTemperatureReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 4: " + ex.Message;
            }

            // Step 5 - Insert the control rods into the reactor
            try
            {
                if (sd.InsertRodCluster() == SwitchDevices.SuccessFailureResult.Success)
                {
                    this.textBlock1.Text += "\nStep 5: Control rods successfully inserted";
                }
                else
                {
                    this.textBlock1.Text += "\nStep 5: Control rod insertion failed";
                }
            }
            catch (SwitchDevices.RodClusterReleaseException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 5: " + ex.Message;
            }

            try
            {
                // Step 6 - Record the core temperature after shutting down the reactor
                this.textBlock1.Text += "\nStep 6: Core temperature after shutdown: " + sd.GetCoreTemperature();

            }
            catch (SwitchDevices.CoreTemperatureReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 6: " + ex.Message;
            }


            try
            {
                // Step 7 - Record the core radiation levels after shutting down the reactor
                this.textBlock1.Text += "\nStep 7: Core radiation level after shutdown: " + sd.GetRadiationLevel();
            }
            catch (SwitchDevices.CoreRadiationLevelReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 7: " + ex.Message;
            }


            try
            {
                // Step 8 - Broadcast "Shutdown Complete" message
                sd.SignalShutdownComplete();
                this.textBlock1.Text += "\nStep 8: Broadcasting shutdown complete message";
            }
            catch (SwitchDevices.SignallingException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 8: " + ex.Message;
            }

            this.textBlock1.Text += "\nTest sequence complete: " + DateTime.Now.ToLongTimeString();
        }
    }
}
