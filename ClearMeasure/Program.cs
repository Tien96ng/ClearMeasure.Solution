using System;
using System.Collections.Generic;

namespace ClearMeasure
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz app = new FizzBuzz();
            List<string> appList = app.Program(100);
            for (int i = 0; i < appList.Count; i++)
            {
                Console.WriteLine(appList[i]);
            }
        }
    }
}
