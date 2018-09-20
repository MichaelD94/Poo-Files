using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_cnsl
{
    class Viagem
    {
        public string Data { get; set; }
        public string Rota { get; set; }
        public double ValorNota { get; set; }
        public double ValorFrete { get; set; }
        public double Combustivel { get; set; }
        public double Alimentação { get; set; }
        public double Manutenção { get; set; }
        public double OutrasDespesas { get; set; }
        public double DespesasT { get; set; }
        public double LucroT { get; set; }

        public Viagem()
        {
            Data = "01/01/1975";
            Rota = "Betim x Cidade";
            ValorNota = 0.0;
            ValorFrete = 0.0;
            Combustivel = 0.0;
            Alimentação = 0.0;
            Manutenção = 0.0;
            OutrasDespesas = 0.0;
            DespesasT = 0.0;
            LucroT = 0.0;
        }
    }
}
