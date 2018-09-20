using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_Classes_Abstratas_e_interface
{
    class Temporarios : Professores
    {
        public string InicioContra { get; set; }
        public string FimContra { get; set; }

        public override void MostraDados()
        {
            Console.Write("Nome:... {0} \n Disciplina:... {1} \n Inicio do Contrato:... {2} \n Fim do Contrato {3}",
                                                                        Nome, Disciplina, InicioContra,FimContra);
        }
    }
}
