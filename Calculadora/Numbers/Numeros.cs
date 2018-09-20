using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Numeros
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public void Soma()
        {
            double soma = Num1 + Num2;
            Console.Write("\n\t{0}", soma);
        }
        public void Subtracao()
        {
            if (Num1 > Num2)
            {
                double subt1 = Num1 - Num2;
                Console.Write("\n\t{0}", subt1);
            }
            else
            {
                double subt2 = Num2 - Num1;
                Console.Write("\n\t{0}", subt2);
            }

        }
        public void Multiplicacao()
        {
            double mult = Num1 * Num2;
            Console.Write("\n\t{0}", mult);
        }
        public void Divisao()
        {
            if (Num1 > Num2)
            {
                double divide0 = Num1 / Num2;
                Console.Write("\n\t{0}", divide0);
            }
            else
            {
                double divide1 = Num2 / Num1;
                Console.Write("\n\t{0}", divide1);
            }
        }
    }
}
