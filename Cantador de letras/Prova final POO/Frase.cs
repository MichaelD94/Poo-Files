using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_final_POO
{
    abstract class Frase
    {
        public abstract int ContadorV(string palavra);
        public abstract int ContadorC(string palavra);
        public abstract int ContadorN(string palavra);
        public abstract int ContadorS(string palavra);

    }
}
