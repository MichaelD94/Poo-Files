using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTad1
{
    struct Aluno
    {
        public string Nome { get; set; }
        public string Mail { get; set; }
        public string Nasc { get; set; }
        public string Tele { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno novoAluno = new Aluno();

            Console.WriteLine("Digite o nome do Aluno");
            novoAluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Email do Aluno");
            novoAluno.Mail = Console.ReadLine();
            Console.WriteLine("Digite a Data de Nascimento do Aluno");
            novoAluno.Nasc = Console.ReadLine();
            Console.WriteLine("Digite o Telefone do Aluno");
            novoAluno.Tele = Console.ReadLine();

            Console.WriteLine("Dados do aluno");
            Console.WriteLine("\nNome : {0} \nEmail : {1} \nData de Nascimento : {2} \nTelefone : {3}",
            novoAluno.Nome,novoAluno.Mail, novoAluno.Nasc, novoAluno.Tele);
            Console.ReadLine();
        }
    }
}
