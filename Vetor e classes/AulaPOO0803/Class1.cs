using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO0803
{
    class Vetor
    {
        public int[] v;

        public Vetor()
        {
            int tam;

            Console.WriteLine(" Tamanho do vetor ?");
            tam = int.Parse(Console.ReadLine());

            v = new int[tam];
        }
        public Vetor(int tam)
        {
            v = new int[tam];
        }
        ~Vetor()
        {
            Console.WriteLine("objeto vetor destruido");
            Console.ReadKey();

        }
        public void geraVetor()
        {
            Random x = new Random();

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = x.Next(1, 100);
            }
            
        }
        public void mostraVetor()
        {
            Console.Clear();

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("{0,6}",v[i]);
            }
            Console.ReadKey();
        }
        
    }
}
