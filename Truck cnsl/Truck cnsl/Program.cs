using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_cnsl
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes MinhasOperacoes = new Operacoes();
            int option = 0;
            do
            {
                Inicio:
                Console.SetCursorPosition(40, 0);
                Console.WriteLine("Sistema de Controle de Viagens");
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("\t 1: Inserir dados de Viagem...");
                Console.WriteLine("\t 2: Listar Viagens");
                Console.WriteLine("\t 3: Calcular Lucro Mensal");
                Console.WriteLine("\t 4: Calcular Despesas Mensais");
                Console.WriteLine("\t 5: para sair do programa");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        MinhasOperacoes.Inserir();
                        goto Inicio;
                    case 2:
                        Console.Clear();
                        MinhasOperacoes.Listar();
                        goto Inicio;
                    case 3:
                        Console.Clear();
                        MinhasOperacoes.CalcM();
                        goto Inicio;
                    case 4:
                        Console.Clear();
                        MinhasOperacoes.DespesasT();
                        goto Inicio;
                        

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Invalida");
                        goto Inicio;
                }

            } while (option != 5);


        }
    }
}



