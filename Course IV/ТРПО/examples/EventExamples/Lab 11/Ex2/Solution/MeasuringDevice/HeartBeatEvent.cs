using System;

namespace MeasuringDevice
{
    // HeartBeatEventArgs class to carry the heartbeat timestamp property.
    public class HeartBeatEventArgs : EventArgs
    {
        public HeartBeatEventArgs()
            : base()
        {
            this.TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; private set; }
    }

    // Delegate defining the HeartBeat event signature.
    public delegate void HeartBeatEventHandler
        (object sender, HeartBeatEventArgs args);
}