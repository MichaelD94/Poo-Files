using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO0604p2
{
    class DeltaEq
    {
        public double CalculaDelta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }

    class RaizesEq : DeltaEq
    {
        public double R1 { get; set; }
        public double R2 { get; set; }

        public void CalculaRaizes(double a, double b, double c)
        {
            R1 = (-b + Math.Sqrt(CalculaDelta(a, b, c))) / (2 * a);
            R2 = (-b - Math.Sqrt(CalculaDelta(a, b, c))) / (2 * a);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Digite o Valor de A ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor de B ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor de C ");
            c = double.Parse(Console.ReadLine());

            RaizesEq MinhasRaizes = new RaizesEq();

            MinhasRaizes.CalculaRaizes(a, b, c);

            Console.WriteLine("\n Raiz 1 = {0:F2}", MinhasRaizes.R1);
            Console.WriteLine("\n Raiz 2 = {0:F2}", MinhasRaizes.R2);
            Console.ReadKey();
        }
    }
}
