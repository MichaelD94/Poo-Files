using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2take
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            
            for (int i = 0; i < n; i++)
            {
                int temp = n1;
                n1 = n2;
                n2 = temp + n2;
            }
            return n1;
        }

        static void Main()
        {
            int z = int.Parse(Console.ReadLine());

            for (int i = 0; i < z; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
