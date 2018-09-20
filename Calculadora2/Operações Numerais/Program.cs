using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_Numerais
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Numeros novosNumeros = new Numeros();
            Console.WriteLine("Digite dois numeros para realizar operações muito loucas");
            novosNumeros.Numero1 = double.Parse(Console.ReadLine());
            novosNumeros.Numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero da operacao que vc deseja realizar");
            Console.WriteLine("1 Soma \n2 Subtracao \n3 Multiplicacao \n4 Divisao");
            int opcao = int.Parse(Console.ReadLine());

            

            switch (opcao)
            {
                case 1:
                   
                    novosNumeros.Soma();
                    
                    goto Inicio;
                case 2:
                   
                    novosNumeros.Subtra();

                    goto Inicio;
                case 3:
                    
                    novosNumeros.Mult();
                    goto Inicio;
                case 4:
                    
                    novosNumeros.Divide();
                    goto Inicio;
                default:
                    break;
            }
        }
    }
}
