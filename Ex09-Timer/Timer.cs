using System;

namespace Ex09_Timer
{
    internal class Timer : TimerTests
    {
        public Timer()
        {
            
        }

        
        public override string ToString()
        {
            int minutes = Seconds/60;
            int hours = minutes / 60;

            minutes = minutes % 60;
            Seconds = Seconds % 60;

            return "" + Padded(hours) + ":" + Padded(minutes) + ":" + Padded(Seconds);

            //Skrevet uden Padded
            //return "" + hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + Seconds.ToString().PadLeft(2, '0');
        }
        public int Seconds { get; internal set; }

        internal string Padded(int v)
        {
            return "" + v.ToString().PadLeft(2, '0');
        }
    }
}