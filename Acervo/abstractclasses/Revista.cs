using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclasses
{
    public class Revista : Itens_do_Acervo
    {
        public string Edicao { get; set; }

        public override void Cadastrar(ArrayList Cad)
        {
            Console.Clear();

            Revista minhaRevista = new Revista();

            Console.Write("Nome da Revista........");
            minhaRevista.Nome = Console.ReadLine();

            Console.Write("Data de Aquisicao........");
            minhaRevista.DatadeAquisicao = Console.ReadLine();

            Console.Write("Edicao da Revista........");
            minhaRevista.Edicao = Console.ReadLine();

            Cad.Add(minhaRevista);
        }
        public override void Listar(ArrayList Cad)
        {
            Console.Clear();
            foreach (Revista x in Cad)
            {
                Console.WriteLine("{0}\n{1}",
                                    x.Nome, x.DatadeAquisicao);

                Console.WriteLine("Autor : \n{0}", x.Edicao);

            }
            Console.ReadKey();
        }
    }
}
