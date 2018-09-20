using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados meusDados = new Dados();

            Livro meuLivro = new Livro();
            Revista minharevista = new Revista();

            for (int i = 0; i < 3; i++)
            {
                meuLivro.Cadastrar(meusDados.Cadl);
            }

            meuLivro.Listar(meusDados.Cadl);            

            for (int i = 0; i < 3; i++)
            {
                minharevista.Cadastrar(meusDados.Cadr);
            }

            minharevista.Listar(meusDados.Cadr);            
        }
    }
}
