using System;
using System.Windows;

namespace TestClient
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.textBlock1.Text = "Initiating test sequence: " + DateTime.Now.ToLongTimeString();
            SwitchDevices.Switch sd = new SwitchDevices.Switch();

            try
            {
                this.textBlock1.Text += (sd.DisconnectPowerGenerator() == SwitchDevices.SuccessFailureResult.Fail) ? "\nStep 1: Failed to disconnect power generation system" : "\nStep 1: Successfully disconnected power generation system";
            }

            catch (SwitchDevices.PowerGeneratorCommsException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 1: " + ex.Message;
            }

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

            try
            {
                this.textBlock1.Text += "\nStep 4: Core temperature before shutdown: " + sd.GetCoreTemperature();
            }
            catch (SwitchDevices.CoreTemperatureReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 4: " + ex.Message;
            }

            try
            {
                this.textBlock1.Text += (sd.InsertRodCluster() == SwitchDevices.SuccessFailureResult.Success) ? "\nStep 5: Control rods successfully inserted" : "\nStep 5: Control rod insertion failed";
            }
            catch (SwitchDevices.RodClusterReleaseException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 5: " + ex.Message;
            }

            try
            {
                this.textBlock1.Text += "\nStep 6: Core temperature after shutdown: " + sd.GetCoreTemperature();
            }

            catch (SwitchDevices.CoreTemperatureReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 6: " + ex.Message;
            }


            try
            {
                this.textBlock1.Text += "\nStep 7: Core radiation level after shutdown: " + sd.GetRadiationLevel();
            }
            catch (SwitchDevices.CoreRadiationLevelReadException ex)
            {
                this.textBlock1.Text += "\n***Exception in step 7: " + ex.Message;
            }

            try
            {
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
