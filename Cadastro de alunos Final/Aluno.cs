using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAgendaBetim
{
    public class Aluno
    {
        private string _Código;
        public string Código
        {
            get { return _Código; }
            set { _Código = value; }
        }
        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        private string _Telefone;
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public Aluno()
        {
            _Código = "";
            _Nome = "";
            _Telefone = "";
            _Email = "";
        }
    }
}
