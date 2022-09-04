using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compound_interest
{
    internal class compound
    {
        public static void Main()
        {
            double principle = 10000, rate = 5, time = 2;

            double A = principle * (Math.Pow((1 +
                        rate / 100), time));
            double CI = A - principle;

            Console.Write("Compound Interest is " + CI);
            Console.ReadLine();
        }
       
    }
