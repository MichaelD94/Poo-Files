using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTad2
{
    struct Aluno
    {
        public string Nome { get; set; }
        public string Mail { get; set; }
        public string Tele { get; set; }

    }
    struct Nascimento
    {
        public int Dia { get; set; }
        public string Mes { get; set; }
        public int Ano { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno novoAluno = new Aluno();
            Nascimento novaData = new Nascimento();

            Console.WriteLine("Digite o nome do Aluno");
            novoAluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Email do Aluno");
            novoAluno.Mail = Console.ReadLine();
            Console.WriteLine("Digite o Telefone do Aluno");
            novoAluno.Tele = Console.ReadLine();
            Console.WriteLine("Agora digite o Dia do Nascimento ");
            novaData.Dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Mes do Nascimento ");
            novaData.Mes =Console.ReadLine();
            Console.WriteLine("Digite o Ano do Nascimento ");
            novaData.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do aluno");
            Console.WriteLine("\nNome : {0} \nEmail : {1} \nTelefone : {2} \nData de Nascimento : {3} {4} {5} ",
            novoAluno.Nome, novoAluno.Mail, novoAluno.Tele, novaData.Dia, novaData.Mes, novaData.Ano);
            Console.ReadLine();
        }
    }
}
