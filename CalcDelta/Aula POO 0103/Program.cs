using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_0103
{
    
    class DeltaEq2
    {
        private double _delta;

        public double delta
        {
            get { return _delta; }
            //set { _delta = value; }//
        }

        public void calcDelta(double a, double b, double c)
        {
            _delta = Math.Pow(b, 2) - 4 * a * c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DeltaEq2 MeuDelta = new DeltaEq2();
            Console.Write("digite o valor de a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("digite o valor de b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("digite o valor de c = ");
            double c = double.Parse(Console.ReadLine());
            MeuDelta.calcDelta(a, b, c);
            Console.WriteLine("\nDelta= {0:F2}", MeuDelta.delta);

            Console.ReadKey();
        }
    }
}

