using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclasses
{
    public class Livro : Itens_do_Acervo
    {
        public string Autor { get; set; }

        public override void Cadastrar(ArrayList Cad)
        {
            Console.Clear();

            Livro meuLivro = new Livro();

            Console.Write("Nome do Livro........");
            meuLivro.Nome = Console.ReadLine();

            Console.Write("Data de Aquisicao........");
            meuLivro.DatadeAquisicao = Console.ReadLine();

            Console.Write("Autor do Livro........");
            meuLivro.Autor = Console.ReadLine();

            Cad.Add(meuLivro);

        }

        public override void Listar(ArrayList Cad)
        {
            Console.Clear();
            foreach (Livro x in Cad)
            {
                Console.WriteLine("{0}\n{1}",
                                    x.Nome, x.DatadeAquisicao);

                Console.WriteLine("Autor : \n{0}", x.Autor);
            }
            Console.ReadKey();
        }

    }
}
