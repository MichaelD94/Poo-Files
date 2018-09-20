using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace abstractclasses
{
    public abstract class Itens_do_Acervo
    {
        public string Nome { get; set; }
        public string DatadeAquisicao { get; set; }

        public abstract void Cadastrar(ArrayList Cad);
        public abstract void Listar(ArrayList Cad);
    }
}
