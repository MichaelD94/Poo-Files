using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_Classes_Abstratas_e_interface
{
    public abstract class Professores
    {
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public string DataNasc { get; set; }

        public Professores()
        {
            Nome = "";
            Disciplina = "";
            DataNasc = "01/01/2000";
        }
        public abstract void MostraDados();
        public virtual void MostraAniv()
        {
            Console.WriteLine("A data de aniversario do professor e:...{0}", DataNasc);
        }



    }
}

