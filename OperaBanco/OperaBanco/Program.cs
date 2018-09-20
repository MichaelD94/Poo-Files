using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nQual seu Tipo de conta?");
            Console.WriteLine("Digite 1 para Corrente e 2 para Poupanca");
            int opcao0 = int.Parse(Console.ReadLine());
            if (opcao0 == 1)
            {
                Console.Clear();
                ContaCorrente novaContaMov = new ContaCorrente();
                int opcao1;
                Inicio1:
                Console.SetCursorPosition(30, 0);
                Console.Write("Escolha qual operação deseja fazer: \t");
                Console.Write("\n\t1- Sacar");
                Console.Write("\n\t2- Depositar");
                Console.Write("\n\t3- Consultar Saldo\n");
                opcao1 = int.Parse(Console.ReadLine());
                switch (opcao1)
                {
                    case 1:
                        Console.Clear();
                        novaContaMov.Sacar();
                        Console.ReadKey();
                        Console.Clear();
                        goto Inicio1;
                    case 2:
                        Console.Clear();
                        novaContaMov.Depositar();
                        Console.ReadKey();
                        Console.Clear();
                        goto Inicio1;
                    case 3:
                        Console.Clear();
                        novaContaMov.Consultar();
                        Console.ReadKey();
                        Console.Clear();
                        goto Inicio1;
                    default:
                        break;
                }
            }
            else
            {
                Console.Clear();
                ContaPoupanca novaContaPoup = new ContaPoupanca();
                int opcao2;
                Inicio2:
                Console.SetCursorPosition(30, 0);
                Console.Write("Escolha qual operação deseja fazer: \t");
                Console.Write("\n\t1- Sacar");
                Console.Write("\n\t2- Depositar");
                Console.Write("\n\t3- Consultar Saldo");
                Console.Write("\n\t4- Calcular Juros\n");
                opcao2 = int.Parse(Console.ReadLine());
                switch (opcao2)
                {
                    case 1:
                        Console.Clear();
                        novaContaPoup.Sacar();
                        Console.ReadKey();
                        Console.Clear();
                        goto Inicio2;
                    case 2:
                        Console.Clear();
                        novaContaPoup.Depositar();
                        Console.ReadKey();
                        Console.Clear();
                        goto Inicio2;
                    case 3:
                        Console.Clear();
                        novaContaPoup.Consultar();
                        Console.ReadKey();
                        Console.Clear();
                        goto Inicio2;
                    case 4:
                        Console.Clear();
                        novaContaPoup.CalcJuros();
                        Console.ReadKey();
                        Console.Clear();
                        goto Inicio2;
                    default:
                        break;
                }
            }
        }
    }
}
