using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Brute Force
            long fn1 = 1;
            long fn2 = 1;
            long summed = 0;
            long result = 0;

            while(result < 4000000)
            {
               if ((result % 2) == 0)
                {
                    summed += result;
                }
                result = fn1 + fn2;
                fn2 = fn1;
                fn1 = result;
            }
            Console.WriteLine(summed);
            #endregion

            #region Reducecd Version
            //long[] fib = { 2, 0 };
            //int i = 0;
            //long summed = 0;

            //while (fib[i] < 4000000)
            //{
            //    summed += fib[i];
            //    i = (i + 1) % 2;
            //    fib[i] = 4 * fib[(i + 1) % 2] + fib[i];
            //}

            //Console.WriteLine(i);
            #endregion
        }
    }
}
