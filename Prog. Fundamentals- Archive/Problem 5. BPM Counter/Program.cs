using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.BPM_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4d;
            double beatsPerSecond = beatsPerMinute / 60d;
            double beats = 0;
            int minutes = 0;
            int seconds = 0;

            for (int n = 0; n < 60; n++)
            {
                beats += beatsPerSecond;

                if (beats >= numberOfBeats && numberOfBeats < beatsPerMinute)
                {
                    seconds = (int)beats;
                    break;
                }
                else if (beats >= numberOfBeats && numberOfBeats >= beatsPerMinute)
                {
                    seconds = n;
                    if (seconds == 59)
                    {
                        minutes++;
                        seconds = 0;
                    }
                    break;
                }

                if (n == 59)
                {
                    minutes++;
                    n = -1;
                }
            }

            Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {seconds}s");
        }
    }
}
