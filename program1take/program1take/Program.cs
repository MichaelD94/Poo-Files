using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1take
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\n" + i);
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" - TakeNet");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" - Take");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" - Net");
                }
            }
            Console.ReadKey();
        }
    }
}
