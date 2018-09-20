using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaBanco
{
    class ContaCorrente
    {
        public int Numero { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }
        public void Sacar()
        {
            Console.SetCursorPosition(30, 0);
            Console.Write("Insira o valor que deseja sacar: \tR$");
            double saque = double.Parse(Console.ReadLine());
            Saldo = Saldo - saque;
        }
        public void Depositar()
        {
            Console.SetCursorPosition(30, 0);
            Console.Write("Insira o valor que deseja depositar: \tR$");
            double deposito = double.Parse(Console.ReadLine());
            Saldo = Saldo + deposito;
        }
        public void Consultar()
        {
            Console.SetCursorPosition(30, 0);
            Console.Write("Insira a senha para consultar seu saldo: \t");
            Console.ReadLine();
            Console.Write("Seu saldo é: {0}", Saldo);
        }
    }
    class ContaPoupanca : ContaCorrente
    {
        
        public double Juros { get; set; }        
        public void CalcJuros()
        {
            Console.SetCursorPosition(30, 0);
            Console.Write("Insira a senha para calcular os juros: \t");
            Console.ReadLine();
            Console.Write("Seus juros mensais são: {0}", Juros);
        }
    }
}
