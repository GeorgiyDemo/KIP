using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    public interface IMeasuringDevice
    {
        /// <summary>
        /// Converts the raw data collected by the measuring device into a metric value.
        /// </summary>
        /// <returns>The latest measurement from the device converted to metric units.</returns>
        decimal MetricValue();

        /// <summary>
        /// Converts the raw data collected by the measuring device into an imperial value.
        /// </summary>
        /// <returns>The latest measurement from the device converted to imperial units.</returns>
        decimal ImperialValue();

        /// <summary>
        /// Starts the measuring device.
        /// </summary>
        void StartCollecting();

        /// <summary>
        /// Stops the measuring device. 
        /// </summary>
        void StopCollecting();

        /// <summary>
        /// Enables access to the raw data from the device in whatever units are native to the device.
        /// </summary>
        /// <returns>The raw data from the device in native format.</returns>
        int[] GetRawData();

        /// <summary>
        /// Returns the file name of the logging file for the device.
        /// </summary>
        /// <returns>The file name of the logging file.</returns>
        string GetLoggingFile();

        /// <summary>
        /// Gets the Units used natively by the device.
        /// </summary>
        Units UnitsToUse { get; }

        /// <summary>
        /// Gets an array of the measurements taken by the device.
        /// </summary>
        int[] DataCaptured { get; }

        /// <summary>
        /// Gets the most recent measurement taken by the device.
        /// </summary>
        int MostRecentMeasure { get; }

        /// <summary>
        /// Gets or sets the name of the logging file used. 
        /// If the logging file changes this closes the current file and creates the new file.
        /// </summary>
        string LoggingFileName { get; set; }
    }
}
