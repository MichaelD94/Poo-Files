using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVeiculos
{
    class Operacoes
    {
        Dados meusDados;
        public Operacoes()
        {
            meusDados = new Dados();
        }
        public void Inserir()
        {
            Veiculo meuVeiculo;
            do
            {
                meuVeiculo = new Veiculo();
                Console.Clear();
                Console.WriteLine("Cadastramento de Veiculo");
                Console.Write("\nPlaca do Veiculo");
                meuVeiculo.Placa = Console.ReadLine();
                Console.Write("\nFabricante: ");
                meuVeiculo.Fabricante = Console.ReadLine();
                Console.Write("\nModelo: ");
                meuVeiculo.Modelo = Console.ReadLine();
                Console.Write("\nAno de Fabricação: ");
                meuVeiculo.AnoFab = Console.ReadLine();
                meusDados.InserirVeiculo(meuVeiculo);
                Console.Write("\nInserir outro registro? (ESC para cancelar)");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public void Listar()
        {
            Veiculo MeuAluno = new Veiculo();
            ArrayList Lista = meusDados.RecuperarDados();
            Console.Clear();
            Console.SetCursorPosition(40, 0);
            Console.Write("\nListagem do cadastro de alunos");
            foreach (Veiculo x in Lista)
            {
                Console.Write("\nNome do aluno {0} ({1})", x.Fabricante, x.Placa);
                Console.Write("\nTelefone: {0}", x.Modelo);
                Console.Write("\nEmail: {0}", x.AnoFab);
            }
        }

        public void Pesquisar()
        {
            Veiculo MeuVeiculo;
            string codPesquisa;
            Console.Clear();
            Console.Write("\nPesquisa no cadastro de Veiculos");
            Console.Write("\nPlaca do Veiculo: ");
            codPesquisa = Console.ReadLine();
            MeuVeiculo = meusDados.PesquisarVeiculo(codPesquisa);
            if (MeuVeiculo != null)
            {
                Console.Write("\nNome do aluno {0} ({1})", MeuVeiculo.Fabricante, MeuVeiculo.Placa);
                Console.Write("\nTelefone: {0}", MeuVeiculo.Modelo);
                Console.Write("\nEmail: {0}", MeuVeiculo.AnoFab);
            }
            else
            {
                Console.Write("\nVeiculo não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void Excluir()
        {
            Veiculo MeuVeiculo;
            string codPesquisa;
            Console.Clear();
            Console.Write("\nExclusão de Veiculo do cadastro ");
            Console.Write("\nPlaca do Veiculo: ");
            codPesquisa = Console.ReadLine();
            MeuVeiculo = meusDados.PesquisarVeiculo(codPesquisa);
            if (MeuVeiculo != null)
            {
                Console.Write("\nNome do aluno {0} ({1})", MeuVeiculo.Fabricante, MeuVeiculo.Placa);
                Console.Write("\nTelefone: {0}", MeuVeiculo.Modelo);
                Console.Write("\nEmail: {0}", MeuVeiculo.AnoFab);
                meusDados.ExcluirVeiculo(MeuVeiculo);
                Console.Write("\nVeiculo excluído");
            }
            else
            {
                Console.Write("\nVeiculo não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void Alterar()
        {
            Veiculo MeuVeiculo;
            Veiculo MeuVeiculoAlterado;
            string codPesquisa;
            Console.Clear();
            Console.Write("\nAlteração de dados do Veiculo no cadastro");
            Console.Write("\nPlaca do Veiculo: ");
            codPesquisa = Console.ReadLine();
            MeuVeiculo = meusDados.PesquisarVeiculo(codPesquisa);
            if (MeuVeiculo != null)
            {
                Console.Write("\nFabricante do Veiculo {0} ({1})", MeuVeiculo.Fabricante, MeuVeiculo.Placa);
                Console.Write("\nModelo: {0}", MeuVeiculo.Modelo);
                Console.Write("\nAno de Fabricação: {0}", MeuVeiculo.AnoFab);
                Console.Write("\n\nDados de atualização: ");
                MeuVeiculoAlterado = new Veiculo();
                Console.Write("\nPlaca do Veiculo: {0}", MeuVeiculoAlterado.Placa = MeuVeiculo.Placa);
                Console.Write("\nFabricante: ");
                MeuVeiculoAlterado.Fabricante = Console.ReadLine();
                Console.Write("\nModelo: ");
                MeuVeiculoAlterado.Modelo = Console.ReadLine();
                Console.Write("\nAno de Fabricação: ");
                MeuVeiculoAlterado.AnoFab = Console.ReadLine();
                meusDados.AlterarVeiculo(MeuVeiculo, MeuVeiculoAlterado);
            }
            else
            {
                Console.Write("\nVeiculo não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void Ordenar()
        {
            int TotReg;
            Console.Clear();
            Console.Write("\nOrdenação de registro do cadastro de Veiculos");
            TotReg = meusDados.OrdenarVeiculo();
            Console.Write("\nTotal de registros: {0}", TotReg);
            Console.ReadKey();
        }
    }
}