using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo2
{
    class Program
    {
        class Aluno
        {
            public int Matricula;
            public string Nome;
            public Data Aniversario;
        }
        class Data
        {
            public int Dia;
            public string Mes;
        }

        static void Main(string[] args)
        {
            Aluno[] MeuAluno = new Aluno [3];

            Aluno xAluno;
            

            for (int i = 0; i < 3; i++)
            {
                xAluno = new Aluno();
                

                Console.WriteLine("Matricula Do Aluno: ");
                xAluno.Matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome Do Aluno: ");
                xAluno.Nome = Console.ReadLine();

                xAluno.Aniversario = new Data();

                Console.WriteLine("Dia do Aniversario: ");
                xAluno.Aniversario.Dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Mes do Aniversario: ");
                xAluno.Aniversario.Mes = Console.ReadLine();

                MeuAluno[i] = xAluno;
            }

            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} - {1} - {2}/{3}",
                                MeuAluno[i].Matricula,
                                MeuAluno[i].Nome,
                                MeuAluno[i].Aniversario.Dia,
                                MeuAluno[i].Aniversario.Mes);
            }
            Console.ReadKey();

        }
    }
}
