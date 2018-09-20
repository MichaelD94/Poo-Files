using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BernardoFullPistola
{
    class Filme
    {
        public string Nome { get; set; }
        public string Ano { get; set; }

        public Filme()
        {
            Nome = "";
            Ano = "";
        }

        public Filme Cadastrar()
        {
            Filme F = new Filme();

            Console.Write("Digite o nome do filme");
            F.Nome = Console.ReadLine();
            Console.Write("Digite o Ano de lancamento");
            F.Ano = Console.ReadLine();

            return F;
        }
        public void Listar(Filme[] Cadf)
        {
            Console.Clear();

            foreach(Filme f in Cadf)
            {
                Console.Write("Nome do filme : {0} \n Ano de Lancamento : {1}", f.Nome, f.Ano);
                
            }
        }
    }

}
