using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{
    

    interface IEventEnabledMeasuringDevice : IMeasuringDevice
    {
        event EventHandler NewMeasurementTaken;

        // Event that fires every heartbeat.
        event HeartBeatEventHandler HeartBeat;

        // Read only heartbeat interval - set in constructor.
        int HeartBeatInterval { get; }
    }
}
