using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using DeviceControl;

namespace Fabrikam.Devices.MeasuringDevices
{
    class LengthMeasuringDevice : IControllableDevice
    {
        Random random;

        /// <summary>
        /// Creates a new instance of the LengthMeasuringDevice class.
        /// </summary>
        public LengthMeasuringDevice()
        {
            random = new Random();
        }

        /// <summary>
        /// Starts the LengthMeasuringDevice 
        /// </summary>
        public void StartDevice()
        {
            // Start the device.           
        }

        /// <summary>
        /// Stops the LengthMeasuringDevice
        /// </summary>
        public void StopDevice()
        {
            // Stop the device.
        }

        /// <summary>
        /// Gets the latest measurement from the LengthMeasuringDevice.
        /// </summary>
        /// <returns>The latest measurment taken by the device.</returns>
        public int GetLatestMeasure()
        {
            Thread.Sleep(random.Next(6000));
            return random.Next(1000);
        }
    }
}
