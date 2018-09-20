using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_cnsl
{
    class Operacoes
    {
        public void Inserir()
        {
            Viagem MinhaViagem = new Viagem();
            Console.WriteLine("Insira os Dados da Viagem");
            Console.WriteLine("Data de Saida");
            MinhaViagem.Data = Console.ReadLine();
            Console.WriteLine("Rota");
            MinhaViagem.Rota = Console.ReadLine();
            Console.WriteLine("Valor da Nota");
            MinhaViagem.ValorNota = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor Frete");
            MinhaViagem.ValorFrete = int.Parse(Console.ReadLine());
            Console.WriteLine("Despesa com Combustivel");
            MinhaViagem.Combustivel = int.Parse(Console.ReadLine());
            Console.WriteLine("Despesa com Alimentação ");
            MinhaViagem.Alimentação = int.Parse(Console.ReadLine());
            Console.WriteLine("Despesas com Manuteção");
            MinhaViagem.Manutenção = int.Parse(Console.ReadLine());
            Console.WriteLine("Outras Despesas");
            MinhaViagem.OutrasDespesas = int.Parse(Console.ReadLine());
            MinhaViagem.DespesasT = MinhaViagem.Combustivel + MinhaViagem.Alimentação + MinhaViagem.Manutenção + MinhaViagem.OutrasDespesas;
            MinhaViagem.LucroT = MinhaViagem.ValorFrete - MinhaViagem.DespesasT;




        }
    }
}
