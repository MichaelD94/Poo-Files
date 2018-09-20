using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BancoVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes MinhasOperacoes = new Operacoes();
            int opcao;
            do
            {
                Inicio:
                Console.Clear();
                Console.SetCursorPosition(40, 0);
                Console.Write("Sistema de cadastro de Veiculos");

                Console.Write("\n\t1 - Inserir");
                Console.Write("\n\t2 - Alterar");
                Console.Write("\n\t3 - Excluir");
                Console.Write("\n\t4 - Pesquisar");
                Console.Write("\n\t5 - Listar");
                Console.Write("\n\t6 - Ordenar");
                Console.Write("\n\t7 - Sair\n");
                Console.Write("\n\tOpção Selecionada:\t");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        MinhasOperacoes.Inserir();
                        goto Inicio;
                    case 2:
                        Console.Clear();
                        MinhasOperacoes.Alterar();
                        goto Inicio;
                    case 3:
                        Console.Clear();
                        MinhasOperacoes.Excluir();
                        goto Inicio;
                    case 4:
                        Console.Clear();
                        MinhasOperacoes.Pesquisar();
                        Console.ReadKey();
                        goto Inicio;
                    case 5:
                        Console.Clear();
                        MinhasOperacoes.Listar();
                        Console.ReadKey();
                        goto Inicio;
                    case 6:
                        Console.Clear();
                        MinhasOperacoes.Ordenar();
                        goto Inicio;
                    case 7:
                        Console.Clear();
                        Console.Write("\nSaída do programa!");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.Clear();
                        Console.Write("\nOpção inválida!!");
                        Thread.Sleep(2000);
                        goto Inicio;
                }
            } while (opcao != 9);
        }
    }
}