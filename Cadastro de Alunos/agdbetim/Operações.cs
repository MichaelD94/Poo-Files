using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaAgendaBetim
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
            Aluno meuAluno;
            do
            {
                meuAluno = new Aluno();
                Console.Clear();
                Console.WriteLine("Cadastramento de alunos");
                meuAluno.Código = GeraCodigo();
                Console.Write("\nCódigo do Aluno: {0}", meuAluno.Código);
                Console.Write("\nNome: ");
                meuAluno.Nome = Console.ReadLine();
                Console.Write("\nTelefone: ");
                meuAluno.Telefone = Console.ReadLine();
                Console.Write("\nEmail: ");
                meuAluno.Email = Console.ReadLine();
                meusDados.InserirAluno(meuAluno);
                Console.Write("\nInserir outro registro? (ESC para cancelar)");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public void Listar()
        {
            Aluno MeuAluno = new Aluno();
            ArrayList Lista = meusDados.RecuperarDados();
            Console.Clear();
            Console.SetCursorPosition(40, 0);
            Console.Write("\nListagem do cadastro de alunos");
            foreach (Aluno x in Lista)
            {
                Console.Write("\nNome do aluno {0} ({1})", x.Nome, x.Código);
                Console.Write("\nTelefone: {0}", x.Telefone);
                Console.Write("\nEmail: {0}", x.Email);
                Console.Write("\n==================================");
            }
        }
        private string GeraCodigo()
        {
            string Result = "";
            DateTime x = new DateTime();
            x = DateTime.Now;
            Result += x.Date.ToString().Substring(0, 2);
            Result += x.Date.ToString().Substring(3, 2);
            Result += x.Date.ToString().Substring(8, 2);
            Result += x.Second.ToString() + x.Minute.ToString() + x.Hour.ToString();
            return Result;
        }
        public void Pesquisar()
        {
            Aluno MeuAluno;
            string codPesquisa;
            Console.Clear();
            Console.Write("\nPesquisa no cadastro de alunos");
            Console.Write("\nCódigo do aluno: ");
            codPesquisa = Console.ReadLine();
            MeuAluno = meusDados.PesquisarAluno(codPesquisa);
            if (MeuAluno != null)
            {
                Console.Write("\nNome do aluno {0} ({1})", MeuAluno.Nome, MeuAluno.Código);
                Console.Write("\nTelefone: {0}", MeuAluno.Telefone);
                Console.Write("\nEmail: {0}", MeuAluno.Email);
            }
            else
            {
                Console.Write("\nAluno não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void Excluir()
        {
            Aluno MeuAluno;
            string codPesquisa;
            Console.Clear();
            Console.Write("\nExclusão de aluno do cadastro de alunos");
            Console.Write("\nCódigo do aluno: ");
            codPesquisa = Console.ReadLine();
            MeuAluno = meusDados.PesquisarAluno(codPesquisa);
            if (MeuAluno != null)
            {
                Console.Write("\nNome do aluno {0} ({1})", MeuAluno.Nome, MeuAluno.Código);
                Console.Write("\nTelefone: {0}", MeuAluno.Telefone);
                Console.Write("\nEmail: {0}", MeuAluno.Email);
                meusDados.ExcluirAluno(MeuAluno);
                Console.Write("\nAluno excluído");
            }
            else
            {
                Console.Write("\nAluno não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void Alterar()
        {
            Aluno MeuAluno;
            Aluno MeuAlunoAlterado;
            string codPesquisa;
            Console.Clear();
            Console.Write("\nAlteração de dados do aluno no cadastro de alunos");
            Console.Write("\nCódigo do aluno: ");
            codPesquisa = Console.ReadLine();
            MeuAluno = meusDados.PesquisarAluno(codPesquisa);
            if (MeuAluno != null)
            {
                Console.Write("\nNome do aluno {0} ({1})", MeuAluno.Nome, MeuAluno.Código);
                Console.Write("\nTelefone: {0}", MeuAluno.Telefone);
                Console.Write("\nEmail: {0}", MeuAluno.Email);
                Console.Write("\n\nDados de atualização: ");
                MeuAlunoAlterado = new Aluno();
                Console.Write("\nCódigo do Aluno: {0}", MeuAlunoAlterado.Código = MeuAluno.Código);
                Console.Write("\nNome: ");
                MeuAlunoAlterado.Nome = Console.ReadLine();
                Console.Write("\nTelefone: ");
                MeuAlunoAlterado.Telefone = Console.ReadLine();
                Console.Write("\nEmail: ");
                MeuAlunoAlterado.Email = Console.ReadLine();
                meusDados.AlterarAluno(MeuAluno, MeuAlunoAlterado);
            }
            else
            {
                Console.Write("\nAluno não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void Ordenar()
        {
            int TotReg;
            Console.Clear();
            Console.Write("\nOrdenação de registro do cadastro de alunos");
            TotReg = meusDados.OrdenarAlunos();
            Console.Write("\nTotal de registros: {0}", TotReg);
            Console.ReadKey();
        }
        public void Salvar()
        {
            int TotReg;
            Console.Clear();
            Console.Write("\nSalvar registro de dados em arquivo XML");
            TotReg = meusDados.SalvarXML();
            Console.Write("\nTotal de registros: {0}", TotReg);
            Console.ReadKey();
        }
        public void Carregar()
        {
            int TotReg;
            Console.Clear();
            Console.Write("\nCarregar registro de dados em arquivo XML");
            TotReg = meusDados.CarregarXML();
            Console.Write("\nTotal de registros: {0}", TotReg);
            Console.ReadKey();
        }
    }
}
