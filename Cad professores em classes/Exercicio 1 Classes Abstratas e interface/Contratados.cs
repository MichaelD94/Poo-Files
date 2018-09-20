using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_Classes_Abstratas_e_interface
{
    class Contratados : Professores
    {
        public string DataAdimissao { get; set; }
        public override void MostraDados()
        {
            Console.Write("Nome:... {0} \n Disciplina:... {1} \n Data de Adimissao:... {2}", 
                                                            Nome, Disciplina, DataAdimissao);
        }
    }
}
