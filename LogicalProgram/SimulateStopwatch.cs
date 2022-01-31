﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class SimulateStopwatch
    {
        public void stopWatch()
        {
            string start = "";
            string end = "";
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Hit ENTER to start the Stopwatch:");
            start = Console.ReadLine();

            if (start.Equals(""))
            {
                DateTime S = DateTime.Now;
                Console.WriteLine("Start Time: " + S);
                stopwatch.Start();

            }

            Console.WriteLine("Hit ENTER to stop the Stopwatch:");
            end = Console.ReadLine();

            if (end.Equals(""))
            {
                DateTime E = DateTime.Now;
                Console.WriteLine("End Time:" + E);
                stopwatch.Stop();
            }

            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time is  : " + ts);
        }
    }
}
