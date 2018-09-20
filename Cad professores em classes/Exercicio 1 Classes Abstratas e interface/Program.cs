using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_Classes_Abstratas_e_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Contratados MeuCont = new Contratados();
            Temporarios MeuTmp = new Temporarios();

            Console.Write("Digite o Nome do Professor");
            MeuCont.Nome = Console.ReadLine();
            Console.Write("Digite a Disciplina do Professor");
            MeuCont.Disciplina = Console.ReadLine();
            Console.Write("Digite a Data de Admissao do Professor");
            MeuCont.DataAdimissao = Console.ReadLine();
            Console.Write("Digite a Data de Aniversario do Professor");
            MeuCont.DataNasc = Console.ReadLine();

            MeuCont.MostraDados();

            Console.ReadKey();

            Console.Clear();

            Console.Write("Digite o Nome do Professor");
            MeuTmp.Nome = Console.ReadLine();
            Console.Write("Digite a Disciplina do Professor");
            MeuTmp.Disciplina = Console.ReadLine();
            Console.Write("Digite a Data de inicio do Contrato");
            MeuTmp.InicioContra = Console.ReadLine();
            Console.Write("Digite a Data de Fim do Contrato");
            MeuTmp.FimContra = Console.ReadLine();
            Console.Write("Digite a Data de Aniversario do Professor");
            MeuTmp.DataNasc = Console.ReadLine();

            MeuTmp.MostraDados();

            Console.ReadKey();

        }
    }
}
