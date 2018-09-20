using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibPuc
{
    public class Operacoes
    {
        public static double[] CriaVetor(int Tam, bool Randomiza)
        {
            double[] result = new double[Tam];

            if (Randomiza)
            {
                Random x = new Random();

                for (int i = 0; i < Tam; i++)
                {
                    result[i] = x.NextDouble();
                }
            }

            return result;
        }

        public static double Soma(double[] Vetor)
        {
            double Soma = 0.0;

            foreach (double x in Vetor)
            {
                Soma += x;
            }

            return Soma;
        }

        public static double AchaMaior(double[] Vetor)
        {
            double Maior = Vetor[0];

            foreach (double x in Vetor)
            {
                if (x > Maior)
                    Maior = x;
            }

            return Maior;
        }

        public static double AchaMenor(double[] Vetor)
        {
            double Menor = Vetor[0];

            foreach (double x in Vetor)
            {
                if (x < Menor)
                    Menor = x;
            }

            return Menor;

        }
    }
}
