using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provapoo
{
    public class Paciente
    {
        private string _Nome;
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        private string _Endereco;
        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
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
        private string __Datanasc;
        public string Datanasc
        {
            get { return __Datanasc; }
            set { __Datanasc = value; }
        }

        public Paciente()
        {
            _Nome = "";
            _Endereco = "";
            _Telefone = "";
            _Email = "";
            __Datanasc = "01/01/1985";
        }
    }
}
