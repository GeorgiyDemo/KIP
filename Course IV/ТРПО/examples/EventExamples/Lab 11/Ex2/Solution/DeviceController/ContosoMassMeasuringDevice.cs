using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using DeviceControl;

namespace Contoso.MeasuringDevices
{
    class MassMeasuringDevice : IControllableDevice
    {
        Random random;

        /// <summary>
        /// Creates a new instance of the MassMeasuringDevice class.
        /// </summary>
        public MassMeasuringDevice()
        {
            random = new Random();
        }

        /// <summary>
        /// Starts the MassMeasuringDevice
        /// </summary>
        public void StartDevice()
        {
            // Start the device.
        }

        /// <summary>
        /// Stops the MassMeasuringDevice
        /// </summary>
        public void StopDevice()
        {
            // Stop the device.
        }

        /// <summary>
        /// Gets the latest measurement from the MassMeasuringDevice.
        /// </summary>
        /// <returns>The latest measurment taken by the device.</returns>
        public int GetLatestMeasure()
        {
            Thread.Sleep(random.Next(5000));
            return random.Next(1390);
        }
    }
}
