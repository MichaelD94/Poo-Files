using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BernardoFullPistola
{
    class Program
    {
        static void Main(string[] args)
        {
            Filme[] vFilme = new Filme[2];
            Terror[] vTerror = new Terror[2];

            Filme movie = new Filme();
            Terror horror = new Terror();
            for (int i = 0; i < 2; i++)
            {
                vFilme[i] = movie.Cadastrar();
            }
            for (int i = 0; i < 2; i++)
            {
                vTerror[i] = horror.Cadastrar();
            }

            movie.Listar(vFilme);
            horror.Listar(vTerror);

            Console.WriteLine("Agora foi poha !!!!!!!!!!");

            Console.ReadKey();
        }
    }
}
