using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwarefundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the ")
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonnaci number is:" + Fibonacci(n));
            Console.ReadLine();
        }


        public static int Fibonacci(int n)
        {
            if(n <= 0)
            {
                return 0;
            }
            else if(n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
