using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibbonacci_Factorial_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Factrorial: "+Factorial(n));
                Console.WriteLine("Fibbonacci: "+Fibbonacci(n));
            }

        }

        static int Factorial(int n)=>Enumerable.Range(1, n).Aggregate((a, b)=>a*b);
        
        static int Fibbonacci(int n)
        {
           
           if (n == 0 || n == 1) return n;
     
           return (n - 1) + (n - 2);
        }
        
    }
}