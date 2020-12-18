using System;
using System.Diagnostics;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[10];

            for (int outTimes = 0; outTimes < 10; outTimes++)
            {
                Stopwatch sw = Stopwatch.StartNew();

                for (int time = 0; time < 1000000; time++)  // lets estimate time how many time it will take to fill this 10 element Array 1000000 times
                {
                    for (int i = 0; i < 10; i++)
                    {
                        a[i] = i;
                    }

                    //a[0] = 0;
                    //a[1] = 1;
                    //a[2] = 2;
                    //a[3] = 3;
                    //a[4] = 4;
                    //a[5] = 5;
                    //a[6] = 6;
                    //a[7] = 7;
                    //a[8] = 8;
                    //a[9] = 9;


                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
            
            // Realease regime makes some optimisations, 
            // debug regime makes no optimisations, Important--always to checks in DEbug Regime, becasue, Realase mode makes  Optimisations!
            // in some cases the faset program is important but, correct giving result program is as important(m ore important) 
            // as fast running program !
            // The software should work Correctly !, in some cases the code quality is most important, in other situations, 
            // code fastness of the code is better desired !
            // the Correctnes of the code is on top level -the software to produce true results !
            // always measure the performance in order to say if one operation is faster than the other operation !
        }
    }
}
