using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpftoc
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            function();
            watch.Stop();
            var elapsedmillisec = watch.ElapsedMilliseconds;
            Console.WriteLine($"Time taken:  {elapsedmillisec / 1000} seconds {elapsedmillisec % 1000} milliseconds");
            Console.ReadKey();

        }

        private static void function()
        {
            double fahr, celsius;
            int lower, upper, step;
                                      /*Implementation could be
                                        better but i dont car*/
            lower = 0;
            upper = 1000000;
            step = 5;

            fahr = lower;
            while (fahr <= upper)
            {
                celsius = (5.0 / 9.0) * (fahr - 32.0);
                Console.WriteLine($"{fahr}  {celsius}");
                fahr = fahr + step;
            }
        }
    }
}
