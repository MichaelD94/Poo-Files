using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Provapoo
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
                Console.Write("Sistema de cadastro de Pacientes");

                Console.Write("\n\t1 - Inserir");
                Console.Write("\n\t2 - Listar");                
                Console.Write("\n\t3 - Sair\n");
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
                        MinhasOperacoes.Listar();
                        Console.ReadKey();
                        goto Inicio;
                    
                    case 3:
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
            } while (opcao != 3);
        }
    }
}