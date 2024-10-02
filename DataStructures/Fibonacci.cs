using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Fibonacci
    {
        public static long FibApp(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            long prev1 = 0, prev2 = 1, result = 0;

            for(int i = 0; i <= n; i++)
            {
                result = prev1 + prev2;
                Console.WriteLine($"F({i}) = {result}");
                prev1 = prev2;
                prev2 = result;
            } 
            return result;
        }
        public static void FibonacciApplication()
        {
            Console.Write("Enter a number to calculate Fibonacci : ");
            int n = int.Parse(Console.ReadLine());

            long fn = FibApp(n);
            Console.WriteLine($"Fibonacci number at position {n} is : {fn}");
        }
    }
}
