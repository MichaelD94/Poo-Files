using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int[] vetor = { 98, 45, 67, 23, 18, 90, 58, 30 };
            int[] vetorb = { 35, 48, 97, 65, 17, 4, 93, 50 };

            var compara = from valor1 in vetor
                          from valor2 in vetorb
                          where valor1 < valor2
                          select new { valor1, valor2 };


            foreach (var x in compara)
            {
                Console.Write("{0} e menor que {1}\t",x.valor1,x.valor2);
            }
            Console.ReadKey();*/

            string[] Vfrutas = { "Banana", "Abacate", "Melancia", "Amora", "Caju", "Abacaxi", "Maca" };


            var selecao = from fruta in Vfrutas
                          orderby fruta
                          group fruta by fruta[0];

            foreach (var Grupofruta in selecao)
            {
                Console.Write("\nFrutas que comecam com {0}",Grupofruta.Key);
                foreach (var f in Grupofruta)
                {
                    Console.WriteLine("\n  => {0}",f);
                }
            }
            Console.ReadKey();
        }
    }
}
