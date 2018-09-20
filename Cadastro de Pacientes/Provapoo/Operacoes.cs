using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provapoo
{
    class Operacoes
    {
        Dados meusDados;
        public Operacoes()
        {
            meusDados = new Dados();
        }
        public void Inserir()
        {
            Paciente meuPaciente;
            do
            {
                meuPaciente = new Paciente();
                Console.Clear();
                Console.WriteLine("Cadastramento de Pacientes");                
                Console.Write("\nNome: ");
                meuPaciente.Nome = Console.ReadLine();
                Console.Write("\nEndereco");
                meuPaciente.Endereco = Console.ReadLine();
                Console.Write("\nTelefone: ");
                meuPaciente.Telefone = Console.ReadLine();
                Console.Write("\nData de Nascimento: ");
                meuPaciente.Datanasc = Console.ReadLine();
                Console.Write("\nEmail: ");
                meuPaciente.Email = Console.ReadLine();
                meusDados.InserirPasciente(meuPaciente);
                Console.Write("\nInserir outro registro? (ESC para cancelar)");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public void Listar()
        {
            Paciente MeuPaciente = new Paciente();
            ArrayList Lista = meusDados.RecuperarDados();
            Console.Clear();
            Console.SetCursorPosition(40, 0);
            Console.Write("\nListagem do cadastro de Pacientes");
            foreach (Paciente x in Lista)
            {
                Console.Write("\nNome do Paciente {0}", x.Nome);
                Console.Write("\nEndereco: {0}", x.Endereco);
                Console.Write("\nTelefone: {0}", x.Telefone);
                Console.Write("\nData de Nascimento: {0}", x.Datanasc);
                Console.Write("\nEmail: {0}", x.Email);
                Console.Write("\n==================================");
            }
        }
        
    }
}
