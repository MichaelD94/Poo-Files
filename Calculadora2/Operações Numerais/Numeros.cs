using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_Numerais
{
    class Numeros
    {
        public double _Numero1;
        public double Numero1
        {
            get { return _Numero1; }
            set { _Numero1 = value; }
        }
        public double _Numero2;
        public double Numero2
        {
            get { return _Numero1; }
            set { _Numero2 = value; }
        }
        public void Soma()
        {
            double soma = Numero1 + Numero2;
            Console.WriteLine(soma);
            Console.ReadKey();
        }
        public void Subtra()
        {
            if (Numero1 > Numero2)
            {
              double sub =  Numero1 - Numero2;
                Console.WriteLine(sub);
            }
            else
            {
                double sub = Numero2 - Numero1;
                Console.WriteLine(sub);
            }
        }
        public void Mult()
        {
            double mult = Numero1 * Numero2;
            Console.WriteLine(mult);
        }
        public void Divide()
        {
            double divide = Numero1 / Numero2;
            Console.WriteLine(divide);
        }
        
    }
}

