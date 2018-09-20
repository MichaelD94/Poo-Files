using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Numbers
{

    class Program : Numeros
    {
        static void Main(string[] args)
        {
            int opcao;
            Numeros novoNumero = new Numeros();
            Console.Write("\nVamos realizar algumas operações. Insira o primeiro número: \n");
            novoNumero.Num1 = double.Parse(Console.ReadLine());
            Console.Write("\nInsira o segundo número : \n");
            novoNumero.Num2 = double.Parse(Console.ReadLine());
            Console.SetCursorPosition(30, 0);
            Inicio:
            Console.Clear();
            Console.Write("Escolha a operação a ser feita com os dois números digitados: (5 para sair)\t");
            Console.Write("\n1 - Soma");
            Console.Write("\n2 - Subtração");
            Console.Write("\n3 - Multiplicação");
            Console.Write("\n4 - Divisão\n");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {

                case 1:
                    novoNumero.Soma();
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                case 2:
                    novoNumero.Subtracao();
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                case 3:
                    novoNumero.Multiplicacao();
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                case 4:
                    novoNumero.Divisao();
                    Console.ReadKey();
                    Console.Clear();
                    goto Inicio;
                case 5:
                    Console.Write("\n\tSaída do programa!");
                    Thread.Sleep(2000);
                    break;
                default:
                    Console.Clear();
                    Console.Write("\n\tInsira uma opção válida!!");
                    Thread.Sleep(2000);
                    goto Inicio;
            }
        }
    }
}

