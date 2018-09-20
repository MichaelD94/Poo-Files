using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_0103P2
{
    class Veiculo
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        private int _anofab;

        public int AnoFab
        {
            get { return _anofab; }
            set { _anofab = value; }
        }

        public Veiculo LeDados()
        {
            Veiculo MeuVeiculo = new Veiculo();

            Console.Write("\nNome do Veiculo .....:");
            MeuVeiculo.Nome = Console.ReadLine();

            Console.Write("\nMarca do Veiculo .....:");
            MeuVeiculo.Marca = Console.ReadLine();

            Console.Write("\nAno de Fabricação do Veiculo .....:");
            MeuVeiculo.AnoFab = int.Parse(Console.ReadLine());
            return MeuVeiculo;
        }
        class Cadastro
        {
            private ArrayList Cad = new ArrayList();

            public void Salvar(Veiculo x)
            {
                Cad.Add(x);
            }

            public void Listar()
            {
                Console.Clear();

                foreach (Veiculo x in Cad)
                {
                    Console.WriteLine("{0} - {1} - ({2})", x.Nome, x.Marca, x.AnoFab);
                }

                Console.ReadKey();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Cadastro MeuCadastro = new Cadastro();

                Veiculo MeuVeiculo = new Veiculo();


                for (int i = 1; i <= 3; i++)
                {
                    MeuCadastro.Salvar(MeuVeiculo.LeDados());
                }

                MeuCadastro.Listar();
            }
        }
    }
}
