using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BernardoFullPistola
{
    class Terror : Filme
    {
        public string Idade { get; set; }

        public Terror()
        {
            Idade = "";
        }
        public Terror Cadastrar()
        {
            Terror T = new Terror();

            Console.Write("Digite o nome do filme");
            T.Nome = Console.ReadLine();
            Console.Write("Digite o Ano de lancamento");
            T.Ano = Console.ReadLine();
            Console.Write("Classe Indicativa do Terror");
            T.Idade = Console.ReadLine();

            return T;
        }

        public void Listar(Terror[] Cadt)
        {
            Console.Clear();

            foreach (Terror t in Cadt)
            {
                Console.Write("Nome do filme : {0} \n Ano de Lancamento : {1} \n Classe Indicativa : {2}", t.Nome, t.Ano, t.Idade);
                
            }
        }
    }
}
