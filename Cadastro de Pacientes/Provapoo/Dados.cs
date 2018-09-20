using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Provapoo
{
    class Dados
    {
        private ArrayList Cadastro;
        public Dados()
        {
            Cadastro = new ArrayList();
        }
        public void InserirPasciente(Paciente x)
        {
            Cadastro.Add(x);
        }
        public ArrayList RecuperarDados()
        {
            return Cadastro;
        }
           
    }
}