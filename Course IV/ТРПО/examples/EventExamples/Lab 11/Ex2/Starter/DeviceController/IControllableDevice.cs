using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceControl
{
    interface IControllableDevice
    {
        /// <summary>
        /// A method to start the device being controlled.
        /// </summary>
        void StartDevice();
        
        /// <summary>
        /// A method to stop the device being controlled.
        /// </summary>
        void StopDevice();
        
        /// <summary>
        ///  A method to force the device to take a measurement.
        /// </summary>
        /// <returns>The measurement taken by the device.</returns>
        int GetLatestMeasure();
    }
}
