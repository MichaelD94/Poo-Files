using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_final_POO
{
    class Caracteres:Frase
    {
        public int z;
        public override int ContadorV(string palavra)
        {
           return z = palavra.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));
        }

        public override int ContadorC(string Palavra)
        {
            return z = Palavra.Count(x => (x == 'b') || (x == 'c') || (x == 'd') || (x == 'f') || (x == 'g') || 
            (x == 'h') || (x == 'j') || (x == 'k') || (x == 'l') || (x == 'm') || (x == 'n') || (x == 'p') 
            || (x == 'q') || (x == 'r') ||(x == 's') || (x == 't') || (x == 'v') || (x == 'x') || (x == 'w') 
            || (x == 'y') || (x == 'z'));
        }
        public override int ContadorN(string Palavra)
        {
            return z = Palavra.Count(x => (x == '0') || (x == '1') || (x == '2') || (x == '3') || (x == '4') ||
                                      (x == '5') || (x == '6') || (x == '7') || (x == '8') || (x == '9'));
        }
        public override int ContadorS(string Palavra)
        {
            return z = Palavra.Count(x => (x == ' '));
        }
    }
}
