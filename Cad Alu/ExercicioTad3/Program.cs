using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTad3
{
    struct Aluno
    {
        public string Nome { get; set; }
        public string Mail { get; set; }
        public string Tele { get; set; }
        public string Dia { get; set; }
        public string Mes { get; set; }
        public string Ano { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno novoAluno = new Aluno();
            Aluno[] cadastros = new Aluno[50];

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Digite o nome do Aluno");
                novoAluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite o Email do Aluno");
                novoAluno.Mail = Console.ReadLine();
                Console.WriteLine("Digite o Telefone do Aluno");
                novoAluno.Tele = Console.ReadLine();
                Console.WriteLine("Agora digite o Dia do Nascimento ");
                novoAluno.Dia = Console.ReadLine();
                Console.WriteLine("Digite o Mes do Nascimento ");
                novoAluno.Mes = Console.ReadLine();
                Console.WriteLine("Digite o Ano do Nascimento ");
                novoAluno.Ano = Console.ReadLine();
                novoAluno = cadastros[i];
            }
            foreach (Aluno x in cadastros)
            {
                Console.WriteLine("Dados do aluno");
                Console.WriteLine("\nNome : {0} \nEmail : {1} \nTelefone : {2} \nData de Nascimento : {3} {4} {5} ",
                x.Nome, x.Mail, x.Tele, x.Dia, x.Mes, x.Ano);
                Console.ReadLine();
            }
        }
    }
}
