using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO0803
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor meuVetorA = new Vetor();
            Vetor meuVetorB = new Vetor();

            meuVetorA.geraVetor();
            meuVetorA.mostraVetor();

            meuVetorB.geraVetor();
            meuVetorB.mostraVetor();
        }
    }
}
